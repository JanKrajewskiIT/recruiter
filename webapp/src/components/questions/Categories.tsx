import { type Props } from "@/models/props";
import { categoriesAtom, selectedCategoryId } from "@/store/questions";
import {
  Chip,
  ToggleButton,
  ToggleButtonGroup,
  Tooltip,
  styled,
} from "@mui/material";
import { useAtom } from "jotai";
import { useCallback, useMemo, useState } from "react";
import { type IconType } from "react-icons";
import { BsDiagram3Fill, BsPersonFillCheck } from "react-icons/bs";
import { CiCircleList } from "react-icons/ci";
import { MdOutlineDisabledByDefault } from "react-icons/md";
import {
  SiAngular,
  SiCsharp,
  SiCss3,
  SiDotnet,
  SiHtml5,
  SiJavascript,
  SiLinux,
  SiMysql,
  SiReact,
  SiTypescript,
} from "react-icons/si";
import { VscOrganization, VscServerProcess } from "react-icons/vsc";

const Icons: Record<string, IconType> = {
  BsDiagram3Fill,
  BsPersonFillCheck,
  CiCircleList,
  MdOutlineDisabledByDefault,
  SiAngular,
  SiCsharp,
  SiCss3,
  SiDotnet,
  SiHtml5,
  SiJavascript,
  SiLinux,
  SiMysql,
  SiReact,
  SiTypescript,
  VscOrganization,
  VscServerProcess,
};

const Categories = ({ className }: Props) => {
  const [{ data }] = useAtom(categoriesAtom);
  const [category, setCategory] = useState<string>();
  const [childCategory, setChildCategory] = useAtom(selectedCategoryId);

  const childCategories = useMemo(
    () => data?.find((c) => c.id === category)?.childCategories,
    [category, data],
  );

  const handleCategoryChange = useCallback(
    (_: any, category: string) => {
      setCategory(category);
      setChildCategory(null);
    },
    [setChildCategory],
  );

  const handleChildCategoryChange = useCallback(
    (category: string) => () => setChildCategory(category),
    [setChildCategory],
  );

  return (
    <div className={className}>
      <ToggleButtonGroup
        className="categories"
        value={category}
        exclusive
        onChange={handleCategoryChange}
      >
        {data?.map((a) => {
          const Icon = a.iconName
            ? Icons[a.iconName]
            : MdOutlineDisabledByDefault;

          return (
            <Tooltip key={a.id} title={a.name}>
              <ToggleButton value={a.id}>
                <Icon size={20} />
              </ToggleButton>
            </Tooltip>
          );
        })}
      </ToggleButtonGroup>
      <div className="child-categories">
        {childCategories?.map((c) => (
          <Chip
            key={c.id}
            label={c.name}
            variant={childCategory === c.id ? "filled" : "outlined"}
            onClick={handleChildCategoryChange(c.id)}
          />
        ))}
      </div>
    </div>
  );
};

export default styled(Categories)`
  & {
    display: flex;
    flex-direction: column;
    align-items: center;
    justify-content: center;
    width: 100%;

    .categories,
    .child-categories {
      margin-bottom: 20px;
    }

    .child-categories {
      display: flex;
      flex-direction: row;
      align-items: center;
      justify-content: center;

      > div {
        margin-right: 4px;
      }
    }
  }
`;
