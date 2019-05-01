using System;
namespace HelloWorld
{
    public class Installer
    {
        private readonly Logger _logger;
        public Installer(Logger logger)
        {
            this._logger = logger;
        }

        public void Install() {
            this._logger.Log("Installing....");
        }


    }
}
