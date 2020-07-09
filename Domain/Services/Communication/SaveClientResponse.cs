using Supermarket.API.Domain.Models;

namespace Supermarket.API.Domain.Services.Communication
{
    public class SaveClientResponse : BaseResponse
    {
        public client client { get; private set; }

        private SaveClientResponse(bool success, string message, client Client) : base(success, message)
        {
            client = Client;
        }

        /// <summary>
        /// Creates a success response.
        /// </summary>
        /// <param name="client">Saved category.</param>
        /// <returns>Response.</returns>
        public SaveClientResponse(client client) : this(true, string.Empty, client)
        { }

        /// <summary>
        /// Creates am error response.
        /// </summary>
        /// <param name="message">Error message.</param>
        /// <returns>Response.</returns>
        public SaveClientResponse(string message) : this(false, message, null)
        { }
    }
}