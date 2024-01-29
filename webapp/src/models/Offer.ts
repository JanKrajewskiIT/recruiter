export default interface Offer {
  id: string;
  name: string;
  link: string;
  company: string;
  city: string;
  reasons: string[];
  description: string | null;
}
