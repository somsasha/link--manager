using System;
using System.Threading.Tasks;
using LinkManager.DAL.Context;
using LinkManager.DAL.Interfaces;
using LinkManager.DAL.Models;
using LinkManager.DAL.Repositories;

namespace LinkManager.DAL
{
    public class UnitOfWork : IDisposable
    {
        private readonly ApplicationDbContext _context;
        private IRepository<Link> _linksRepository;
        private IRepository<Tag> _tagsRepository;
        private IRepository<LinkTags> _linkTagsRepository;

        public IRepository<Link> LinksRepository
        {
            get
            {
                return _linksRepository = _linksRepository ?? new BaseRepository<Link>(_context);
            }
        }

        public IRepository<Tag> TagsRepository
        {
            get
            {
                return _tagsRepository = _tagsRepository ?? new BaseRepository<Tag>(_context);
            }
        }

        public IRepository<LinkTags> LinkTagsRepository
        {
            get
            {
                return _linkTagsRepository = _linkTagsRepository ?? new BaseRepository<LinkTags>(_context);
            }
        }

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        private bool _disposed;

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            _disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
