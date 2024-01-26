export interface Category {
  id: string;
  name: string;
  description: string | null;
  iconName: string | null;
  childCategories: Category[];
}
