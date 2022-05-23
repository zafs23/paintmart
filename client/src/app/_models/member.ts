import { Painting } from "./painting";

export interface Member {
    id: number;
    userName: string;
    profilePhotoUrl: string;
    age: number;
    knownAs: string;
    created: Date;
    lastActive: Date;
    paintingType: string;
    motivation: string;
    interested: string;
    personalInterests: string;
    city: string;
    country: string;
    paintings: Painting[];
}

