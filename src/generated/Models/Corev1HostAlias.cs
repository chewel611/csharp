// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace k8s.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// HostAlias holds the mapping between IP and hostnames that will be
    /// injected as an entry in the pod's hosts file.
    /// </summary>
    public partial class Corev1HostAlias
    {
        /// <summary>
        /// Initializes a new instance of the Corev1HostAlias class.
        /// </summary>
        public Corev1HostAlias()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Corev1HostAlias class.
        /// </summary>
        /// <param name="hostnames">Hostnames for the above IP address.</param>
        /// <param name="ip">IP address of the host file entry.</param>
        public Corev1HostAlias(IList<string> hostnames = default(IList<string>), string ip = default(string))
        {
            Hostnames = hostnames;
            Ip = ip;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets hostnames for the above IP address.
        /// </summary>
        [JsonProperty(PropertyName = "hostnames")]
        public IList<string> Hostnames { get; set; }

        /// <summary>
        /// Gets or sets IP address of the host file entry.
        /// </summary>
        [JsonProperty(PropertyName = "ip")]
        public string Ip { get; set; }

    }
}
