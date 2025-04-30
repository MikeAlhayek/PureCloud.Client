using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloudPlatform.Client.V2.Model;

/// <summary>
/// Location
/// </summary>
[DataContract]
public partial class Location : IEquatable<Location>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Location" /> class.
    /// </summary>
    /// <param name="Id">Unique identifier for the location.</param>
    /// <param name="Coordinates">Users coordinates on the floorplan. Only used when floorplanImage is set.</param>
    /// <param name="Notes">Optional description on the users location.</param>
    /// <param name="LocationDefinition">LocationDefinition.</param>
    public Location(string Id = null, Dictionary<string, double?> Coordinates = null, string Notes = null, LocationDefinition LocationDefinition = null)
    {
        this.Id = Id;
        this.Coordinates = Coordinates;
        this.Notes = Notes;
        this.LocationDefinition = LocationDefinition;

    }



    /// <summary>
    /// Unique identifier for the location
    /// </summary>
    /// <value>Unique identifier for the location</value>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; set; }



    /// <summary>
    /// Unique identifier for the location floorplan image
    /// </summary>
    /// <value>Unique identifier for the location floorplan image</value>
    [DataMember(Name = "floorplanId", EmitDefaultValue = false)]
    public string FloorplanId { get; private set; }



    /// <summary>
    /// Users coordinates on the floorplan. Only used when floorplanImage is set
    /// </summary>
    /// <value>Users coordinates on the floorplan. Only used when floorplanImage is set</value>
    [DataMember(Name = "coordinates", EmitDefaultValue = false)]
    public Dictionary<string, double?> Coordinates { get; set; }



    /// <summary>
    /// Optional description on the users location
    /// </summary>
    /// <value>Optional description on the users location</value>
    [DataMember(Name = "notes", EmitDefaultValue = false)]
    public string Notes { get; set; }



    /// <summary>
    /// Gets or Sets LocationDefinition
    /// </summary>
    [DataMember(Name = "locationDefinition", EmitDefaultValue = false)]
    public LocationDefinition LocationDefinition { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class Location {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  FloorplanId: ").Append(FloorplanId).Append("\n");
        sb.Append("  Coordinates: ").Append(Coordinates).Append("\n");
        sb.Append("  Notes: ").Append(Notes).Append("\n");
        sb.Append("  LocationDefinition: ").Append(LocationDefinition).Append("\n");
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
        return this.Equals(obj as Location);
    }

    /// <summary>
    /// Returns true if Location instances are equal
    /// </summary>
    /// <param name="other">Instance of Location to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(Location other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                this.Id == other.Id ||
                this.Id != null &&
                this.Id.Equals(other.Id)
            ) &&
            (
                this.FloorplanId == other.FloorplanId ||
                this.FloorplanId != null &&
                this.FloorplanId.Equals(other.FloorplanId)
            ) &&
            (
                this.Coordinates == other.Coordinates ||
                this.Coordinates != null &&
                this.Coordinates.SequenceEqual(other.Coordinates)
            ) &&
            (
                this.Notes == other.Notes ||
                this.Notes != null &&
                this.Notes.Equals(other.Notes)
            ) &&
            (
                this.LocationDefinition == other.LocationDefinition ||
                this.LocationDefinition != null &&
                this.LocationDefinition.Equals(other.LocationDefinition)
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
            if (this.Id != null)
            {
                hash = hash * 59 + this.Id.GetHashCode();
            }

            if (this.FloorplanId != null)
            {
                hash = hash * 59 + this.FloorplanId.GetHashCode();
            }

            if (this.Coordinates != null)
            {
                hash = hash * 59 + this.Coordinates.GetHashCode();
            }

            if (this.Notes != null)
            {
                hash = hash * 59 + this.Notes.GetHashCode();
            }

            if (this.LocationDefinition != null)
            {
                hash = hash * 59 + this.LocationDefinition.GetHashCode();
            }

            return hash;
        }
    }
}
