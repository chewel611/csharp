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
    /// JobStatus represents the current state of a Job.
    /// </summary>
    public partial class Apibatchv1JobStatus
    {
        /// <summary>
        /// Initializes a new instance of the Apibatchv1JobStatus class.
        /// </summary>
        public Apibatchv1JobStatus()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Apibatchv1JobStatus class.
        /// </summary>
        /// <param name="active">The number of actively running pods.</param>
        /// <param name="completionTime">Represents time when the job was
        /// completed. It is not guaranteed to be set in happens-before order
        /// across separate operations. It is represented in RFC3339 form and
        /// is in UTC.</param>
        /// <param name="conditions">The latest available observations of an
        /// object's current state. More info:
        /// https://kubernetes.io/docs/concepts/workloads/controllers/jobs-run-to-completion/</param>
        /// <param name="failed">The number of pods which reached phase
        /// Failed.</param>
        /// <param name="startTime">Represents time when the job was
        /// acknowledged by the job controller. It is not guaranteed to be set
        /// in happens-before order across separate operations. It is
        /// represented in RFC3339 form and is in UTC.</param>
        /// <param name="succeeded">The number of pods which reached phase
        /// Succeeded.</param>
        public Apibatchv1JobStatus(int? active = default(int?), System.DateTime? completionTime = default(System.DateTime?), IList<Apibatchv1JobCondition> conditions = default(IList<Apibatchv1JobCondition>), int? failed = default(int?), System.DateTime? startTime = default(System.DateTime?), int? succeeded = default(int?))
        {
            Active = active;
            CompletionTime = completionTime;
            Conditions = conditions;
            Failed = failed;
            StartTime = startTime;
            Succeeded = succeeded;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the number of actively running pods.
        /// </summary>
        [JsonProperty(PropertyName = "active")]
        public int? Active { get; set; }

        /// <summary>
        /// Gets or sets represents time when the job was completed. It is not
        /// guaranteed to be set in happens-before order across separate
        /// operations. It is represented in RFC3339 form and is in UTC.
        /// </summary>
        [JsonProperty(PropertyName = "completionTime")]
        public System.DateTime? CompletionTime { get; set; }

        /// <summary>
        /// Gets or sets the latest available observations of an object's
        /// current state. More info:
        /// https://kubernetes.io/docs/concepts/workloads/controllers/jobs-run-to-completion/
        /// </summary>
        [JsonProperty(PropertyName = "conditions")]
        public IList<Apibatchv1JobCondition> Conditions { get; set; }

        /// <summary>
        /// Gets or sets the number of pods which reached phase Failed.
        /// </summary>
        [JsonProperty(PropertyName = "failed")]
        public int? Failed { get; set; }

        /// <summary>
        /// Gets or sets represents time when the job was acknowledged by the
        /// job controller. It is not guaranteed to be set in happens-before
        /// order across separate operations. It is represented in RFC3339 form
        /// and is in UTC.
        /// </summary>
        [JsonProperty(PropertyName = "startTime")]
        public System.DateTime? StartTime { get; set; }

        /// <summary>
        /// Gets or sets the number of pods which reached phase Succeeded.
        /// </summary>
        [JsonProperty(PropertyName = "succeeded")]
        public int? Succeeded { get; set; }

    }
}
