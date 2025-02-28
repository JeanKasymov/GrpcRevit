using Autodesk.Revit.UI;

namespace RevitAddinOutOfContext_gRPC_Client
{
    /// <summary>
    /// Класс для работы Revit с внешним событием 
    /// </summary>
    public class ModelessWindowHandler : IExternalEventHandler
    {
        private readonly ExternalEvent _externalEvent;
        public ModelessWindowHandler()
        {
            _externalEvent = ExternalEvent.Create(this);
        }
        //public ModelessViewModel ViewModel { get; set; }
        public void Raise()
        {
            _externalEvent.Raise();
        }
        public void Execute(UIApplication app)
        {

        }
        public string GetName()
        {
            return nameof(ModelessWindowHandler);
        }
    }
}
