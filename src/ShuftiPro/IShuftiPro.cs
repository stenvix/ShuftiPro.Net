using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using ShuftiPro.Contracts;
using ShuftiPro.Options;

namespace ShuftiPro
{
    public interface IShuftiPro
    {
        Task<ShuftiProFeedback> VerifyAsync(ShuftiProVerification verification, CancellationToken cancellationToken = default);

        Task<ShuftiProFeedback> VerifyAsync(ShuftiProVerification verification, ShuftiProCredentials requestCredentials, CancellationToken cancellationToken = default);

        Task<ShuftiProStatus> GetStatusAsync(ShuftiProReference reference, CancellationToken cancellationToken = default);

        Task<ShuftiProStatus> GetStatusAsync(ShuftiProReference reference, ShuftiProCredentials requestCredentials, CancellationToken cancellationToken = default);

        Task<byte[]> GetProofAsync(ShuftiProProofAccess accessToken, Uri uri, CancellationToken cancellationToken = default);
    }
}