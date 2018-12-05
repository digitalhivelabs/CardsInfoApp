import { PreviewPhotoUrl } from './psPreviewPhotoUrl';

export interface PhotoGallery {
    id: number;
    displayLabel: string;
    photoPackUrl: string;
    qtyPhotos: number;
    previewPhotosUrl: PreviewPhotoUrl[];
}
