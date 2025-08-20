using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Plexo
{
    [DataContract]
    public class TokenizationSettingsFields
    {
        [DataMember]
        public TokenizationSettingsFieldValues Cardholder { get; set; } = new TokenizationSettingsFieldValues();
        [DataMember]
        public TokenizationSettingsFieldValues Identification { get; set; } = new TokenizationSettingsFieldValues();
        [DataMember]
        public TokenizationSettingsFieldValues BillingAddress { get; set; } = new TokenizationSettingsFieldValues();
    }

    /// <summary>
    /// Represents the visibility state for a tokenization settings field.
    /// </summary>
    public class TokenizationSettingsFieldValues
    {
        /// <summary>
        /// Gets or sets the visibility of the field. Allowed values: OnlyIfRequired, Always, Never.
        /// </summary>
        [DataMember]
        public TokenizationFieldVisibility Visible { get; set; } = TokenizationFieldVisibility.OnlyIfRequired;

        /// <summary>
        /// Gets or sets whether the field is read-only.
        /// </summary>
        [DataMember]
        public bool ReadOnly { get; set; } = false;
    }

    /// <summary>
    /// Enum representing allowed visibility values for tokenization settings fields.
    /// </summary>
    public enum TokenizationFieldVisibility
    {
        [EnumMember]
        OnlyIfRequired = 0,
        [EnumMember]
        Always = 1,
        [EnumMember]
        Never = 2
    }
}
