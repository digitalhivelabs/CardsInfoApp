using System.Threading.Tasks;
using CardsProfileApp.API.Models;
using Microsoft.EntityFrameworkCore;

namespace CardsProfileApp.API.Data
{
    public class PSRepository : IPSRepository
    {
        private readonly DataContext _context;

        public PSRepository(DataContext context)
        {
            this._context = context;
        }

        public async Task<PSProfile> GetProfile(int profileId)
        {
            //var x = await this._context.PSProfiles.CountAsync();
            var profile = await this._context.PSProfiles.Include(k => k.KnownAsNames)
                .Include(s => s.SocialNetworks)
                .Include(ds => ds.DataSpecifications)
                .Include(rl => rl.RelatedLinks)
                .Include(q => q.RelevantQuestions)
                .Include(p => p.PhotoGalleries).ThenInclude(ps => ps.PreviewPhotosUrls)
                .Include(v => v.VideoGalleries).ThenInclude(dl => dl.DownloadLinks).ThenInclude(u => u.Urls)
                .FirstOrDefaultAsync(p => p.Id == profileId);

            return profile;
        }

        public async Task<bool> SaveAll()
        {
            return await this._context.SaveChangesAsync() > 0;
        }
    }
}