using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using SnmpSharpNet;

namespace SNMP_agent {
    internal class OidExtented : Oid {
        private readonly string _patternOid;
        private readonly string _octet;
        public int CountOfOctets {get; private set; }

        public OidExtented(uint[] array) : base(array) {}
        public OidExtented() : base() {}
        public OidExtented(string str) :base(str) {
            var array = Regex.Split(str, @"\.");
            var patternArray = new uint[array.Length-2];
            for (int i = 0; i < patternArray.Length; i++)
                patternArray[i] = uint.Parse(array[i+1]);
            _patternOid = new Oid(patternArray).ToString();
            _octet = array[array.Length-1];
            CountOfOctets = patternArray.Length;
        }

        public bool CompareOid(string oid) {
            var array = Regex.Split(oid, @"\.");
            string compareStr = "1";
            for (var i = 1; i < CountOfOctets+1; i++)
                compareStr += "." + array[i];
            if ((_patternOid+"."+_octet).Equals(compareStr))
                return true;

            return false;
        }
    }
}