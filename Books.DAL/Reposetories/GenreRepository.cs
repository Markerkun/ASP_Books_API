using Books.DAL.Entities;
using Books.DAL.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books.DAL.Reposetories
{
    public class GenreRepository : GenericRepository<GenreEntity>
    {
        public GenreRepository(AppDbContext context)
            : base(context)
        {

        }

        public IQueryable<GenreEntity> Genres => GetAll();

        public async Task<bool> IsExistAsync(string name)
        {
            return await Genres.AnyAsync(g => g.Name.ToLower() == name.ToLower());
        }

        public async Task<GenreEntity?> GetByNameAsync(string name)
        {
            return await Genres.FirstOrDefaultAsync(g => g.Name.ToLower() == name.ToLower());
        }
    }
}
