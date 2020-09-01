using System;
using System.Threading.Tasks;

namespace Aladon.Domain.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        IUsersRepository Users { get; }
        IRolesRepository Roles { get; }
        IUserRolesRepository UserRoles { get; }
        IPermissionsRepository Permissions { get; }
        IModulesRepository Modules { get; }
        ILocationTypesRepository LocationTypes { get; }
        IAssetStructureRepository AssetStructures { get; }
        IAssetPartInforRepository AssetPartInfors { get; }
        IAssetTypeRepository AssetTypes { get; }
        IDocumentRepository Documents { get; }
        IPartRepository Parts { get; }

        IAssetTagRepository AssetTags { get; }
        Task CompleteAsync();
    }
}
