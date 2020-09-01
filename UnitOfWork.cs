
using Aladon.Domain.Entities;
using Aladon.Domain.Repositories;
using System;

namespace Aladon.Data.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        public AladonContext Context { get; private set; }
        public UnitOfWork(AladonContext context)
        {
            Context = context;
            Users = new UsersRepository(context);
            Roles = new RolesRepository(context);
            UserRoles = new UserRolesRepository(context);
            Permissions = new PermissionsRepository(context);
            Modules = new ModulesRepository(context);
            LocationTypes = new LocationTypesRepository(context);
            AssetStructures = new AssetStructureRepository(context);
            AssetPartInfors = new AssetPartInforRepository(context);
            AssetTypes = new AssetTypeRepository(context);
            Documents = new DocumentRepository(context);
            Parts = new PartRepository(context);
            AssetTags = new AssetTagRepository(context);
        }
        private bool disposed = false;

        public IAssetTypeRepository AssetTypes { get; private set; }
        public IDocumentRepository Documents { get; }
        public IUsersRepository Users { get; private set; }
        public IRolesRepository Roles { get; private set; }
        public IUserRolesRepository UserRoles { get; private set; }
        public IPermissionsRepository Permissions { get; private set; }
        public IModulesRepository Modules { get; }
        public ILocationTypesRepository LocationTypes { get; }
        public IAssetStructureRepository AssetStructures { get; private set; }

        public IAssetPartInforRepository AssetPartInfors { get; private set; }
        public IPartRepository Parts { get; private set; }
        public IAssetTagRepository AssetTags { get; private set; }

        public async System.Threading.Tasks.Task CompleteAsync()
        {
            await Context.SaveChangesAsync();
        }

        public void Dispose()
        {
            Dispose(true);

            // Use SupressFinalize in case a subclass 
            // of this type implements a finalizer.
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    // Clear all property values that maybe have been set
                    // when the class was instantiated
                    Context.Dispose();
                }

                // Indicate that the instance has been disposed.
                disposed = true;
            }
        }

    }
}

