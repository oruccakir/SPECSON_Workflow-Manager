namespace Improved_Workflow_Manager
{
   // This interface is used to define the methods that are required for the MassFlowController class.
   public interface MassFlowControllerInterface
   {
        // This method is used to set the flow rate of the MassFlowController. Using Connection class, we can set the flow rate of the MassFlowController.
        public bool setMfcFlowRate(double mfcFlowRate);

        // This method is used to read the flow rate of the MassFlowController. Using Connection class, we can read the flow rate of the MassFlowController.
        public double readMfcFlowRate();

        // This method is used to set the name of the MassFlowController.
        void setMfcName(string mfcName);
    
        // This method is used to get the name of the MassFlowController.
        string getMfcName();
    
        // This method is used to set the gas name of the MassFlowController.
        void setMfcGasName(string mfcGasName);
    
        // This method is used to get the gas name of the MassFlowController.
        string getMfcGasName();
    
        // This method is used to set the id of the MassFlowController.
        void setMfcId(int mfcId);
    
        // This method is used to get the id of the MassFlowController.
        int getMfcId();
    
        // This method is used to set the color of the MassFlowController.
        void setMfcColor(Color mfcColor);
    
        // This method is used to get the color of the MassFlowController.
        Color getMfcColor();

        // This method is used to set the initial pressure of the MassFlowController.
        void setMfcInitialPressure(double mfcInitialPressure);

        // This method is used to get the initial pressure of the MassFlowController.
        double getMfcInitialPressure();

        // This method is used to set isConnected of the MassFlowController.
        void setIsConnected(bool isConnected);

        // This method is used to get isConnected of the MassFlowController.
        bool getIsConnected();

        // This method is used to set the minimum flow rate of the MassFlowController.
        void setMinFlowRate(double minFlowRate);

        // This method is used to get the minimum flow rate of the MassFlowController.
        double getMinFlowRate();

        // This method is used to set the maximum flow rate of the MassFlowController.
        void setMaxFlowRate(double maxFlowRate);

        // This method is used to get the maximum flow rate of the MassFlowController.
        double getMaxFlowRate();

   }
}