import { PSSocialNetwork } from './psSocialNetwork';
import { PSDataSpecification } from './psDataSpecification';
import { PSRelatedLink } from './psRelatedLinks';
import { PSRelevantQuestion } from './psRelevantQuestion';
import { PhotoGallery } from './psPhotoGallery';
import { PSVideoGallery } from './psVideoGallery';

export interface PSProfile {
    id: number;
    knownName: string;
    knownNames: string;
    birthDate: Date;
    age: number;
    sign: string;
    birthPlace: string;
    birthCountry: string;
    residence: string;
    residenceCountry: string;
    careerStartYear: number;
    careerEndYear: number;
    yearsInBusiness: number;
    height: string;
    weight: string;
    bodyType: string;
    measurements: string;
    breast: string;
    tattos: string;
    piercings: string;
    scortingProfileId: number;
    photoUrl: string;
    whatWeKnow: string;
    otherRelatedInfo: string;
    socialNetworks: PSSocialNetwork[];
    dataSpecifications: PSDataSpecification[];
    relatedLinks: PSRelatedLink[];
    relevantQuestions: PSRelevantQuestion[];
    photoGalleries: PhotoGallery[];
    videoGalleries: PSVideoGallery[];
}
