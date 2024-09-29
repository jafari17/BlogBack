 
export interface Posts {
    postId:number;
    title:string;
    userId:string;
    categoryTitle:string;
    categoryId:number;
    labels?: Labels[];
    description:string;
    active?:boolean;
    postDirectory:string;
    postDate:Date;
}
export interface Labels {
    labelName:string;
}