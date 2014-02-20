using Nancy;

namespace mam.servicedesk.serverportal
{
    public class ServerDialog : NancyModule
    {
        public ServerDialog()
        {
            Get["/pleasehelp"] = _ => { ServerPortal.Instance.Feuern("Pleasehelp"); return HttpStatusCode.OK; };
            Get["/reset"] = _ => { ServerPortal.Instance.Feuern("Reset"); return HttpStatusCode.OK; };
        }
    }
}
