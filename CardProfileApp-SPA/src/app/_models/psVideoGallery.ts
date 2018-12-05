import { PSVideoGalleryLinks } from './psVideoGalleryLinks';

export interface PSVideoGallery {
    displayValue: string;
    previewUrl: string;
    description: string;
    downloadLinks: PSVideoGalleryLinks[];
}
