using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SNMP_agent {
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ISnmpService" in both code and config file together.
    [ServiceContract]
    public interface ISnmpService {
        [OperationContract]
        void DoWork();
    }
}
