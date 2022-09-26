using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OnvifCamera.Authentication;
using OnvifCamera.Device;
using OnvifCamera.Logging;
using OnvifCamera.Media;
using OnvifCamera.PTZ;

namespace OnvifCamera.Service
{
    static class OnvifServices
    {
        static MediaClient mediaclient;
        static DeviceClient deviceclient;
        static MediaUri mediauri;
        static PTZClient ptzclient;

        
        public static PTZClient GetOnvifPTZClient(string IPAddress, string username = "", string password = "")
        {
            try
            {
                var httpTransportBinding = new HttpTransportBindingElement { AuthenticationScheme = System.Net.AuthenticationSchemes.Digest };
                var textMessageEncodingBinding = new TextMessageEncodingBindingElement { MessageVersion = MessageVersion.CreateVersion(EnvelopeVersion.Soap12, AddressingVersion.None) };
                var customBinding = new CustomBinding(textMessageEncodingBinding, httpTransportBinding);

                EndpointAddress PTZEndPoint = new EndpointAddress("http://" + IPAddress + "/onvif/ptz_service");
                ptzclient = new PTZClient(customBinding, PTZEndPoint);
                if (username != string.Empty && username != null)
                {
                    PasswordDigestBehavior passwordDigestBehavior = new PasswordDigestBehavior(username, password);
                    ptzclient.Endpoint.Behaviors.Add(passwordDigestBehavior);
                }

                return ptzclient;

            }
            catch (Exception ex)
            {
                EventLogging.LogEvents("Function: GetOnvifPTZClient()" + ex);
                return ptzclient;
            }

        }

        internal static PTZClient GetOnvifPTZClient(TextBox ipAdress, TextBox login, TextBox password)
        {
            throw new NotImplementedException();
        }

        internal static MediaClient GetOnvifMediaClient(TextBox ipAdress, TextBox login, TextBox password)
        {
            throw new NotImplementedException();
        }

        public static MediaClient GetOnvifMediaClient(string IPAddress, string username = "", string password = "")
        {
            try
            {
                var httpTransportBinding = new HttpTransportBindingElement { AuthenticationScheme = System.Net.AuthenticationSchemes.Digest };
                var textMessageEncodingBinding = new TextMessageEncodingBindingElement { MessageVersion = MessageVersion.CreateVersion(EnvelopeVersion.Soap12, AddressingVersion.None) };
                var customBinding = new CustomBinding(textMessageEncodingBinding, httpTransportBinding);

                EndpointAddress MediaEndpoint = new EndpointAddress("http://" + IPAddress + "/onvif/media_service");
                mediaclient = new MediaClient(customBinding, MediaEndpoint);
                if (username != string.Empty && username != null)
                {
                    PasswordDigestBehavior passwordDigestBehavior = new PasswordDigestBehavior(username, password);
                    mediaclient.Endpoint.Behaviors.Add(passwordDigestBehavior);
                }

                return mediaclient;
            }
            catch (Exception ex)
            {
                EventLogging.LogEvents("Function: GetOnvifMediaClient()" + ex);
                return mediaclient;
            }
        }
        

        public static DeviceClient GetOnvifDeviceClient(string IPAddress, string username = "", string password = "")
        {
            try
            {
                var httpTransportBinding = new HttpTransportBindingElement { AuthenticationScheme = System.Net.AuthenticationSchemes.Digest };
                var textMessageEncodingBinding = new TextMessageEncodingBindingElement { MessageVersion = MessageVersion.CreateVersion(EnvelopeVersion.Soap12, AddressingVersion.None) };
                var customBinding = new CustomBinding(textMessageEncodingBinding, httpTransportBinding);

                EndpointAddress DeviceEndpoint = new EndpointAddress("http://" + IPAddress + "/onvif/device_service");
                deviceclient = new DeviceClient(customBinding, DeviceEndpoint);
                if (username != string.Empty && username != null)
                {
                    PasswordDigestBehavior passwordDigestBehavior = new PasswordDigestBehavior(username, password);
                    deviceclient.Endpoint.Behaviors.Add(passwordDigestBehavior);
                }

                return deviceclient; 
            }
            catch (Exception ex)
            {
                EventLogging.LogEvents("Function: GetOnvifDeviceClientx()" + ex);
                return deviceclient;
            }
        }

        public static MediaUri GetStreamURI(MediaClient mediaclient, string token)
        {
            try
            {

                var StreamSetup = new StreamSetup()
                {
                    Stream = StreamType.RTPUnicast,
                    Transport = new Transport()
                    {
                        Protocol = TransportProtocol.UDP
                    }
                };

                mediauri = mediaclient.GetStreamUri(StreamSetup, token);
                return mediauri;
            }
            catch (Exception ex)
            {
                EventLogging.LogEvents("Function: GetStreamURI()" + ex);
                return mediauri;
            }
        }
    }
}
