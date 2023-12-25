"use client";

import { type PropsWithClassName } from "@/models/props";
import styled from "@emotion/styled";
import {
  Box,
  Button,
  Card,
  CardActions,
  CardContent,
  Typography,
} from "@mui/material";

const array = [1, 2, 3, 4, 5, 6, 7, 8];

const bull = (
  <Box
    component="span"
    sx={{ display: "inline-block", mx: "2px", transform: "scale(0.8)" }}
  >
    •
  </Box>
);

const Home = ({ className }: PropsWithClassName) => (
  <main className={className}>
    {array.map((a) => (
      <Card key={a} sx={{ minWidth: 275 }}>
        <CardContent>
          <Typography sx={{ fontSize: 14 }} color="text.secondary" gutterBottom>
            Word of the Day
          </Typography>
          <Typography variant="h5" component="div">
            be{bull}nev{bull}o{bull}lent
          </Typography>
          <Typography sx={{ mb: 1.5 }} color="text.secondary">
            adjective
          </Typography>
          <Typography variant="body2">
            well meaning and kindly.
            <br />
            {'"a benevolent smile"'}
          </Typography>
        </CardContent>
        <CardActions>
          <Button size="small">Learn More</Button>
        </CardActions>
      </Card>
    ))}
  </main>
);

export default styled(Home)`
  & {
    display: grid;
    grid-gap: 15px;
    margin: 20px;
    grid-template-columns: repeat(auto-fit, minmax(300px, 1fr));
  }
`;
