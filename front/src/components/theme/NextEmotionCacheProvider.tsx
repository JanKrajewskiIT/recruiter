"use client";

import * as React from "react";
import createCache from "@emotion/cache";
import { useServerInsertedHTML } from "next/navigation";
import { CacheProvider } from "@emotion/react";
import type { Options } from "@emotion/cache";
import { Fragment } from "react";

export interface INextEmotionCacheProviderProps {
  options: Omit<Options, "insertionPoint">;
}

const NextEmotionCacheProvider = ({
  options,
  children,
}: React.PropsWithChildren<INextEmotionCacheProviderProps>) => {
  const [{ cache, flush }] = React.useState(() => {
    const cache = createCache(options);
    cache.compat = true;
    // eslint-disable-next-line @typescript-eslint/unbound-method
    const prevInsert = cache.insert;
    let inserted: Array<{ name: string; isGlobal: boolean }> = [];
    cache.insert = (...args) => {
      const [selector, serialized] = args;
      if (cache.inserted[serialized.name] === undefined) {
        inserted.push({
          name: serialized.name,
          isGlobal: !selector,
        });
      }
      return prevInsert(...args);
    };
    const flush = () => {
      const prevInserted = inserted;
      inserted = [];
      return prevInserted;
    };
    return { cache, flush };
  });

  useServerInsertedHTML(() => {
    const inserted = flush();
    if (inserted.length === 0) {
      return null;
    }
    let styles = "";
    let dataEmotionAttribute = cache.key;

    const globals: Array<{
      name: string;
      style: string;
    }> = [];

    inserted.forEach(({ name, isGlobal }) => {
      const style = cache.inserted[name];

      if (typeof style !== "boolean") {
        if (isGlobal) {
          globals.push({ name, style });
        } else {
          styles += style;
          dataEmotionAttribute += ` ${name}`;
        }
      }
    });

    return (
      <Fragment>
        {globals.map(({ name, style }) => (
          <style
            key={name}
            data-emotion={`${cache.key}-global ${name}`}
            dangerouslySetInnerHTML={{ __html: style }}
          />
        ))}
        {styles && (
          <style
            data-emotion={dataEmotionAttribute}
            dangerouslySetInnerHTML={{ __html: styles }}
          />
        )}
      </Fragment>
    );
  });

  return <CacheProvider value={cache}>{children}</CacheProvider>;
};

export default NextEmotionCacheProvider;
