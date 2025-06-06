using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// BuForecastTimeSeriesResult
/// </summary>

public partial class BuForecastTimeSeriesResult : IEquatable<BuForecastTimeSeriesResult>
{
    /// <summary>
    /// The metric this result applies to
    /// </summary>
    /// <value>The metric this result applies to</value>
    
    public enum MetricEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Offered for "Offered"
        /// </summary>
        [EnumMember(Value = "Offered")]
        Offered,

        /// <summary>
        /// Enum Averagehandletimeseconds for "AverageHandleTimeSeconds"
        /// </summary>
        [EnumMember(Value = "AverageHandleTimeSeconds")]
        Averagehandletimeseconds
    }
    /// <summary>
    /// The forecasting method that was used for this metric
    /// </summary>
    /// <value>The forecasting method that was used for this metric</value>
    
    public enum ForecastingMethodEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Autoregressiveintegratedmovingaverage for "AutoRegressiveIntegratedMovingAverage"
        /// </summary>
        [EnumMember(Value = "AutoRegressiveIntegratedMovingAverage")]
        Autoregressiveintegratedmovingaverage,

        /// <summary>
        /// Enum Movingaverage for "MovingAverage"
        /// </summary>
        [EnumMember(Value = "MovingAverage")]
        Movingaverage,

        /// <summary>
        /// Enum Singleexponentialsmoothing for "SingleExponentialSmoothing"
        /// </summary>
        [EnumMember(Value = "SingleExponentialSmoothing")]
        Singleexponentialsmoothing,

        /// <summary>
        /// Enum Randomwalk for "RandomWalk"
        /// </summary>
        [EnumMember(Value = "RandomWalk")]
        Randomwalk,

        /// <summary>
        /// Enum Decompositionusingadditiveseasonality for "DecompositionUsingAdditiveSeasonality"
        /// </summary>
        [EnumMember(Value = "DecompositionUsingAdditiveSeasonality")]
        Decompositionusingadditiveseasonality,

        /// <summary>
        /// Enum Decompositionusingmultiplicativeseasonality for "DecompositionUsingMultiplicativeSeasonality"
        /// </summary>
        [EnumMember(Value = "DecompositionUsingMultiplicativeSeasonality")]
        Decompositionusingmultiplicativeseasonality,

        /// <summary>
        /// Enum Holtwintersadditiveseasonality for "HoltWintersAdditiveSeasonality"
        /// </summary>
        [EnumMember(Value = "HoltWintersAdditiveSeasonality")]
        Holtwintersadditiveseasonality,

        /// <summary>
        /// Enum Holtwintersadditiveseasonalitywithdampedtrend for "HoltWintersAdditiveSeasonalityWithDampedTrend"
        /// </summary>
        [EnumMember(Value = "HoltWintersAdditiveSeasonalityWithDampedTrend")]
        Holtwintersadditiveseasonalitywithdampedtrend,

        /// <summary>
        /// Enum Holtwintersmultiplicativeseasonality for "HoltWintersMultiplicativeSeasonality"
        /// </summary>
        [EnumMember(Value = "HoltWintersMultiplicativeSeasonality")]
        Holtwintersmultiplicativeseasonality,

        /// <summary>
        /// Enum Holtwintersmultiplicativeseasonalitywithdampedtrend for "HoltWintersMultiplicativeSeasonalityWithDampedTrend"
        /// </summary>
        [EnumMember(Value = "HoltWintersMultiplicativeSeasonalityWithDampedTrend")]
        Holtwintersmultiplicativeseasonalitywithdampedtrend,

        /// <summary>
        /// Enum Dampedlinearexponentialsmoothing for "DampedLinearExponentialSmoothing"
        /// </summary>
        [EnumMember(Value = "DampedLinearExponentialSmoothing")]
        Dampedlinearexponentialsmoothing,

        /// <summary>
        /// Enum Doubleexponentialsmoothing for "DoubleExponentialSmoothing"
        /// </summary>
        [EnumMember(Value = "DoubleExponentialSmoothing")]
        Doubleexponentialsmoothing,

        /// <summary>
        /// Enum Doublemovingaverage for "DoubleMovingAverage"
        /// </summary>
        [EnumMember(Value = "DoubleMovingAverage")]
        Doublemovingaverage,

        /// <summary>
        /// Enum Linearexponentialsmoothing for "LinearExponentialSmoothing"
        /// </summary>
        [EnumMember(Value = "LinearExponentialSmoothing")]
        Linearexponentialsmoothing,

        /// <summary>
        /// Enum Linearweightedmovingaverage for "LinearWeightedMovingAverage"
        /// </summary>
        [EnumMember(Value = "LinearWeightedMovingAverage")]
        Linearweightedmovingaverage,

        /// <summary>
        /// Enum Pointestimateusingdampedlinearexponentialsmoothing for "PointEstimateUsingDampedLinearExponentialSmoothing"
        /// </summary>
        [EnumMember(Value = "PointEstimateUsingDampedLinearExponentialSmoothing")]
        Pointestimateusingdampedlinearexponentialsmoothing,

        /// <summary>
        /// Enum Pointestimateusingdoubleexponentialsmoothing for "PointEstimateUsingDoubleExponentialSmoothing"
        /// </summary>
        [EnumMember(Value = "PointEstimateUsingDoubleExponentialSmoothing")]
        Pointestimateusingdoubleexponentialsmoothing,

        /// <summary>
        /// Enum Pointestimateusinglatestweek for "PointEstimateUsingLatestWeek"
        /// </summary>
        [EnumMember(Value = "PointEstimateUsingLatestWeek")]
        Pointestimateusinglatestweek,

        /// <summary>
        /// Enum Pointestimateusinglinearexponentialsmoothing for "PointEstimateUsingLinearExponentialSmoothing"
        /// </summary>
        [EnumMember(Value = "PointEstimateUsingLinearExponentialSmoothing")]
        Pointestimateusinglinearexponentialsmoothing,

        /// <summary>
        /// Enum Pointestimateusingweightedaverage for "PointEstimateUsingWeightedAverage"
        /// </summary>
        [EnumMember(Value = "PointEstimateUsingWeightedAverage")]
        Pointestimateusingweightedaverage,

        /// <summary>
        /// Enum Curvefit for "CurveFit"
        /// </summary>
        [EnumMember(Value = "CurveFit")]
        Curvefit,

        /// <summary>
        /// Enum Multilinearregression for "MultiLinearRegression"
        /// </summary>
        [EnumMember(Value = "MultiLinearRegression")]
        Multilinearregression,

        /// <summary>
        /// Enum Dynamicharmonicregression for "DynamicHarmonicRegression"
        /// </summary>
        [EnumMember(Value = "DynamicHarmonicRegression")]
        Dynamicharmonicregression,

        /// <summary>
        /// Enum Theta for "Theta"
        /// </summary>
        [EnumMember(Value = "Theta")]
        Theta,

        /// <summary>
        /// Enum Ensemble for "Ensemble"
        /// </summary>
        [EnumMember(Value = "Ensemble")]
        Ensemble,

        /// <summary>
        /// Enum Other for "Other"
        /// </summary>
        [EnumMember(Value = "Other")]
        Other
    }
    /// <summary>
    /// The forecasting type in this forecast result
    /// </summary>
    /// <value>The forecasting type in this forecast result</value>
    
    public enum ForecastTypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Longterm for "LongTerm"
        /// </summary>
        [EnumMember(Value = "LongTerm")]
        Longterm,

        /// <summary>
        /// Enum Shortterm for "ShortTerm"
        /// </summary>
        [EnumMember(Value = "ShortTerm")]
        Shortterm
    }
    /// <summary>
    /// The metric this result applies to
    /// </summary>
    /// <value>The metric this result applies to</value>
    [JsonPropertyName("metric")]
    public MetricEnum? Metric { get; set; }
    /// <summary>
    /// The forecasting method that was used for this metric
    /// </summary>
    /// <value>The forecasting method that was used for this metric</value>
    [JsonPropertyName("forecastingMethod")]
    public ForecastingMethodEnum? ForecastingMethod { get; set; }
    /// <summary>
    /// The forecasting type in this forecast result
    /// </summary>
    /// <value>The forecasting type in this forecast result</value>
    [JsonPropertyName("forecastType")]
    public ForecastTypeEnum? ForecastType { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="BuForecastTimeSeriesResult" /> class.
    /// </summary>
    /// <param name="Metric">The metric this result applies to.</param>
    /// <param name="ForecastingMethod">The forecasting method that was used for this metric.</param>
    /// <param name="ForecastType">The forecasting type in this forecast result.</param>
    public BuForecastTimeSeriesResult(MetricEnum? Metric = null, ForecastingMethodEnum? ForecastingMethod = null, ForecastTypeEnum? ForecastType = null)
    {
        this.Metric = Metric;
        this.ForecastingMethod = ForecastingMethod;
        this.ForecastType = ForecastType;

    }








    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class BuForecastTimeSeriesResult {\n");

        sb.Append("  Metric: ").Append(Metric).Append("\n");
        sb.Append("  ForecastingMethod: ").Append(ForecastingMethod).Append("\n");
        sb.Append("  ForecastType: ").Append(ForecastType).Append("\n");
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
        return Equals(obj as BuForecastTimeSeriesResult);
    }

    /// <summary>
    /// Returns true if BuForecastTimeSeriesResult instances are equal
    /// </summary>
    /// <param name="other">Instance of BuForecastTimeSeriesResult to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(BuForecastTimeSeriesResult other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Metric == other.Metric ||
                Metric != null &&
                Metric.Equals(other.Metric)
            ) &&
            (
                ForecastingMethod == other.ForecastingMethod ||
                ForecastingMethod != null &&
                ForecastingMethod.Equals(other.ForecastingMethod)
            ) &&
            (
                ForecastType == other.ForecastType ||
                ForecastType != null &&
                ForecastType.Equals(other.ForecastType)
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
            if (Metric != null)
            {
                hash = hash * 59 + Metric.GetHashCode();
            }

            if (ForecastingMethod != null)
            {
                hash = hash * 59 + ForecastingMethod.GetHashCode();
            }

            if (ForecastType != null)
            {
                hash = hash * 59 + ForecastType.GetHashCode();
            }

            return hash;
        }
    }
}
