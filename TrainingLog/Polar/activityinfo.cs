//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:2.0.50727.5477
//
//     �nderungen an dieser Datei k�nnen falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Xml.Serialization;

// 
// This source code was auto-generated by xsd, Version=2.0.50727.1432.
// 


namespace TrainingLog.Polar
{
  /// <remarks/>
  [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [XmlType(TypeName = "activity-info", Namespace = "http://www.polarpersonaltrainer.com")]
  [XmlRoot("activity-info", Namespace = "http://www.polarpersonaltrainer.com", IsNullable = false)]
  public partial class activityinfo
  {

    private string stepsField;

    private string infitnesszoneField;

    private string inhealthzoneField;

    /// <remarks/>
    [XmlElement(DataType = "nonNegativeInteger")]
    public string steps
    {
      get
      {
        return this.stepsField;
      }
      set
      {
        this.stepsField = value;
      }
    }

    /// <remarks/>
    [XmlElement("in-fitness-zone")]
    public string infitnesszone
    {
      get
      {
        return this.infitnesszoneField;
      }
      set
      {
        this.infitnesszoneField = value;
      }
    }

    /// <remarks/>
    [XmlElement("in-health-zone")]
    public string inhealthzone
    {
      get
      {
        return this.inhealthzoneField;
      }
      set
      {
        this.inhealthzoneField = value;
      }
    }
  }
}