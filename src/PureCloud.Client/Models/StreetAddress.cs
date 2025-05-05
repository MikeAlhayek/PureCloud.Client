using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// StreetAddress
/// </summary>

public partial class StreetAddress : IEquatable<StreetAddress>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="StreetAddress" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected StreetAddress() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="StreetAddress" /> class.
    /// </summary>
    /// <param name="Country">2 Letter Country code, like US or GB (required).</param>
    /// <param name="A1">State or Province (required).</param>
    /// <param name="A3">City or township (required).</param>
    /// <param name="RD">Number and street (required).</param>
    /// <param name="HNO">House Number (required).</param>
    /// <param name="LOC">extra location info like suite 300.</param>
    /// <param name="NAM">Name of the customer.</param>
    /// <param name="PC">Postal code (required).</param>
    public StreetAddress(string Country = null, string A1 = null, string A3 = null, string RD = null, string HNO = null, string LOC = null, string NAM = null, string PC = null)
    {
        this.Country = Country;
        this.A1 = A1;
        this.A3 = A3;
        this.RD = RD;
        this.HNO = HNO;
        this.LOC = LOC;
        this.NAM = NAM;
        this.PC = PC;

    }



    /// <summary>
    /// 2 Letter Country code, like US or GB
    /// </summary>
    /// <value>2 Letter Country code, like US or GB</value>
    [JsonPropertyName("country")]
    public string Country { get; set; }



    /// <summary>
    /// State or Province
    /// </summary>
    /// <value>State or Province</value>
    [JsonPropertyName("A1")]
    public string A1 { get; set; }



    /// <summary>
    /// City or township
    /// </summary>
    /// <value>City or township</value>
    [JsonPropertyName("A3")]
    public string A3 { get; set; }



    /// <summary>
    /// Number and street
    /// </summary>
    /// <value>Number and street</value>
    [JsonPropertyName("RD")]
    public string RD { get; set; }



    /// <summary>
    /// House Number
    /// </summary>
    /// <value>House Number</value>
    [JsonPropertyName("HNO")]
    public string HNO { get; set; }



    /// <summary>
    /// extra location info like suite 300
    /// </summary>
    /// <value>extra location info like suite 300</value>
    [JsonPropertyName("LOC")]
    public string LOC { get; set; }



    /// <summary>
    /// Name of the customer
    /// </summary>
    /// <value>Name of the customer</value>
    [JsonPropertyName("NAM")]
    public string NAM { get; set; }



    /// <summary>
    /// Postal code
    /// </summary>
    /// <value>Postal code</value>
    [JsonPropertyName("PC")]
    public string PC { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class StreetAddress {\n");

        sb.Append("  Country: ").Append(Country).Append("\n");
        sb.Append("  A1: ").Append(A1).Append("\n");
        sb.Append("  A3: ").Append(A3).Append("\n");
        sb.Append("  RD: ").Append(RD).Append("\n");
        sb.Append("  HNO: ").Append(HNO).Append("\n");
        sb.Append("  LOC: ").Append(LOC).Append("\n");
        sb.Append("  NAM: ").Append(NAM).Append("\n");
        sb.Append("  PC: ").Append(PC).Append("\n");
        sb.Append("}\n");
        return sb.ToString();
    }


    /// <summary>
    /// Returns true if objects are equal
    /// </summary>
    /// <param name="obj">Object to be compared</param>
    /// <returns>Boolean</returns>
    public override bool Equals(object obj)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        return Equals(obj as StreetAddress);
    }

    /// <summary>
    /// Returns true if StreetAddress instances are equal
    /// </summary>
    /// <param name="other">Instance of StreetAddress to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(StreetAddress other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Country == other.Country ||
                Country != null &&
                Country.Equals(other.Country)
            ) &&
            (
                A1 == other.A1 ||
                A1 != null &&
                A1.Equals(other.A1)
            ) &&
            (
                A3 == other.A3 ||
                A3 != null &&
                A3.Equals(other.A3)
            ) &&
            (
                RD == other.RD ||
                RD != null &&
                RD.Equals(other.RD)
            ) &&
            (
                HNO == other.HNO ||
                HNO != null &&
                HNO.Equals(other.HNO)
            ) &&
            (
                LOC == other.LOC ||
                LOC != null &&
                LOC.Equals(other.LOC)
            ) &&
            (
                NAM == other.NAM ||
                NAM != null &&
                NAM.Equals(other.NAM)
            ) &&
            (
                PC == other.PC ||
                PC != null &&
                PC.Equals(other.PC)
            );
    }

    /// <summary>
    /// Gets the hash code
    /// </summary>
    /// <returns>Hash code</returns>
    public override int GetHashCode()
    {
        // credit: http://stackoverflow.com/a/263416/677735
        unchecked // Overflow is fine, just wrap
        {
            int hash = 41;
            // Suitable nullity checks etc, of course :)
            if (Country != null)
            {
                hash = hash * 59 + Country.GetHashCode();
            }

            if (A1 != null)
            {
                hash = hash * 59 + A1.GetHashCode();
            }

            if (A3 != null)
            {
                hash = hash * 59 + A3.GetHashCode();
            }

            if (RD != null)
            {
                hash = hash * 59 + RD.GetHashCode();
            }

            if (HNO != null)
            {
                hash = hash * 59 + HNO.GetHashCode();
            }

            if (LOC != null)
            {
                hash = hash * 59 + LOC.GetHashCode();
            }

            if (NAM != null)
            {
                hash = hash * 59 + NAM.GetHashCode();
            }

            if (PC != null)
            {
                hash = hash * 59 + PC.GetHashCode();
            }

            return hash;
        }
    }
}
