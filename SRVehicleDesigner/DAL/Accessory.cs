using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace SRVehicleDesigner.DAL
{
    [DataContract(Namespace = "")]
    public enum Accessory
    {
        [EnumMember]RemoteControlInterface,
        [EnumMember]RiggerAdaptation,
        [EnumMember]LivingAmenitiesBasic,
        [EnumMember]Military,
        [EnumMember]Security
    }
}
