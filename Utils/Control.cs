using System.IO.Ports;

namespace ArduinoController
{
    public class Control : IDisposable
    {
        private const int defaultSleep = 1000;

        private int baudRate;
        private int dataBits;
        private int readTimeOut;
        private int writeTimeOut;
        private Parity parity;
        private StopBits stopBits;
        private Handshake handShake;
        private readonly string? portName;

        private readonly SerialPort serialPort;
        private readonly bool defaultMode = false;

        public Control() { serialPort = new SerialPort(); }

        /// <summary>
        /// This constructor use <see cref="DefaultBoardConfiguration"/>
        /// </summary>
        /// <param name="portName"></param>
        public Control(string _portName)
        {
            portName = _portName;

            defaultMode = true;
            serialPort = new SerialPort();
        }

        public Control(string _portName, int _baudRate, int _dataBits, int _readTimeOut, int _writeTimeOut, Parity _parity, StopBits _stopBits, Handshake _handShake)
        {
            baudRate = _baudRate;
            parity = _parity;
            dataBits = _dataBits;
            stopBits = _stopBits;
            handShake = _handShake;
            readTimeOut = _readTimeOut;
            writeTimeOut = _writeTimeOut;
            portName = _portName;

            defaultMode = false;
            serialPort = new SerialPort();
        }

        public bool IsConnected { get => serialPort!.IsOpen; }
        public bool IsDefaultMode { get => defaultMode; }
        public string? ReadedData { get; private set; } = null;
        public List<string> AllReadedData { get; private set; } = new List<string>();


        #region Reset

        /// <summary>
        /// Reset serialPort
        /// </summary>
        public void Reset(bool defaultConfiguration)
        {
            Dispose();
            ResetConfiguration(defaultConfiguration);
            InitializeSerialPort();
        }

        private void ResetConfiguration(bool defaultConfiguration)
        {
            if (defaultConfiguration) SetDefaultConfiguration();
            else
            {
                serialPort!.PortName = portName;
                serialPort!.BaudRate = baudRate;
                serialPort!.Parity = parity;
                serialPort!.DataBits = dataBits;
                serialPort!.StopBits = stopBits;
                serialPort!.Handshake = handShake;
                serialPort!.ReadTimeout = readTimeOut;
                serialPort!.WriteTimeout = writeTimeOut;
            }
        }

        #endregion

        #region Open / Dispose

        /// <summary>
        /// Initialize serial port = serialPort.Open()
        /// </summary>
        public void InitializeSerialPort() { serialPort!.Open(); }

        /// <summary>
        /// Following IDispose
        /// </summary>
        public void Dispose() => Dispose(null);

        /// <summary>
        /// Dispose Serial Port Connection
        /// </summary>
        public void Dispose(string? instructionToSendToTurnOffBoard)
        {
            if (IsConnected)
            {
                if (!string.IsNullOrEmpty(instructionToSendToTurnOffBoard))
                {
                    serialPort!.Write(instructionToSendToTurnOffBoard);
                    Thread.Sleep(defaultSleep);
                }

                serialPort!.Dispose();
            }
        }

        #endregion

        #region Set Parameters

        /// <summary>
        /// Set a Received Event Handler to handler data received from board
        /// </summary>
        /// <param name="dataReceivedHandler"></param>
        public void SetDataReceivedEventHandler(SerialDataReceivedEventHandler dataReceivedHandler) { serialPort!.DataReceived += dataReceivedHandler; }

        public void SetDefaultConfiguration()
        {
            baudRate = 115200;
            parity = Parity.None;
            dataBits = 8;
            stopBits = StopBits.One;
            handShake = Handshake.None;
            readTimeOut = 20;
            writeTimeOut = 20;
        }

        #endregion

    }
}

