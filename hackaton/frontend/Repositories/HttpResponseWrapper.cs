using System.Net;

namespace Hackaton.frontend.Repositories
{
    public class HttpResponseWrapper<T>
    {
        public T? Response { get; set; }
        public HttpResponseMessage HttpResponseMessage { get; set; }
        public bool Error { get; set; }
        public HttpResponseWrapper(T? response, bool error, HttpResponseMessage httpResponseMessage)
        {
            Error = error;
            Response = response;
            HttpResponseMessage = httpResponseMessage;
        }
        public async Task<string?> GetErrorMessage()
        {
            if (!Error)
            {
                return null;
            }

            var codigoStatus = HttpResponseMessage.StatusCode;
            if (codigoStatus == HttpStatusCode.NotFound)
            {
                return "Recurso no encontrado";
            }
            else if(codigoStatus == HttpStatusCode.BadRequest)
            {
                return await HttpResponseMessage.Content.ReadAsStringAsync();
            }
            else if (codigoStatus == HttpStatusCode.Unauthorized)
            {
                return "Debes logearte apra realizar esta acción";
            }
            else if (codigoStatus == HttpStatusCode.Forbidden)
            {
                return "No tienes permisos para ejecutar esta acción";
            }

            return "Ha ocurrido un error inesperado";
        }
    }
}