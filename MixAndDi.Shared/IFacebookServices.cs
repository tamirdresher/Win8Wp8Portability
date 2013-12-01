using System.Threading.Tasks;

namespace MixAndDi.Shared
{
    public interface IFacebookServices
    {
        /// <summary>
        /// Login to facebook and returns the access token
        /// </summary>
        /// <returns>the access token</returns>
        Task<string> Login();
    }
}