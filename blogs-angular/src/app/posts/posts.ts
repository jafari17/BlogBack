 
export interface Posts {
    postId:number;
    title:string;
    categoryTitle:string;
    categoryId:number;
    labels?: Labels[];
    description:string;
    active?:boolean;
}
export interface Labels {
    labelName:string;
}