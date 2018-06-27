// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Everything.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from Everything.proto</summary>
public static partial class EverythingReflection {

  #region Descriptor
  /// <summary>File descriptor for Everything.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static EverythingReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "ChBFdmVyeXRoaW5nLnByb3RvGhtnb29nbGUvcHJvdG9idWYvZW1wdHkucHJv",
          "dG8aH2dvb2dsZS9wcm90b2J1Zi90aW1lc3RhbXAucHJvdG8iOwoHV29ya291",
          "dBISCgN3aG8YASABKAsyBS5Vc2VyEhwKBXN0YXRlGAIgASgOMg0uV29ya291",
          "dFN0YXRlImwKCEV4ZXJjaXNlEgwKBG5hbWUYASABKAkSGwoEdHlwZRgCIAEo",
          "DjINLkV4ZXJjaXNlVHlwZRIRCgNzZXQYAyADKAsyBC5TZXQSDAoEbm90ZRgK",
          "IAEoCRoUCgRUeXBlEgwKBG5hbWUYASABKAkiMAoRUmVwZWF0ZWRFeGVyY2lz",
          "ZXMSGwoIZXhlcmNpc2UYASADKAsyCS5FeGVyY2lzZSIYCgNTZXQSEQoDcmVw",
          "GAEgAygLMgQuUmVwIkQKA1JlcBIOCgZhbW91bnQYASABKAUSDgoGd2VpZ2h0",
          "GAIgASgFEh0KBXVuaXRzGAMgASgOMg4uVW5pdHNNYXNzVHlwZSIYCgRVc2Vy",
          "EhAKCHVzZXJuYW1lGAEgASgJKjAKDFdvcmtvdXRTdGF0ZRIJCgVTVEFSVBAA",
          "EggKBFNUT1AQARILCgdSRVNUQVJUEAIqNQoMRXhlcmNpc2VUeXBlEgwKCFNU",
          "UkVOR1RIEAASCgoGQ0FSRElPEAESCwoHU1RSRVRDSBACKj8KDVVuaXRzTWFz",
          "c1R5cGUSBwoDTEJTEAASCgoGUE9VTkRTEAASBgoCS0cQARINCglLSUxPR1JB",
          "TVMQARoCEAEy2AIKCkV2ZXJ5dGhpbmcSNQoPR2V0RXhlY2lzZXNPZl9SEg4u",
          "RXhlcmNpc2UuVHlwZRoSLlJlcGVhdGVkRXhlcmNpc2VzEi4KD0dldEV4ZWNp",
          "c2VzT2ZfUxIOLkV4ZXJjaXNlLlR5cGUaCS5FeGVyY2lzZTABEjAKDFN0YXJ0",
          "V29ya291dBIWLmdvb2dsZS5wcm90b2J1Zi5FbXB0eRoILldvcmtvdXQSLwoL",
          "U3RvcFdvcmtvdXQSFi5nb29nbGUucHJvdG9idWYuRW1wdHkaCC5Xb3Jrb3V0",
          "EkoKGEdldEV4ZXJjaXNlSGlzdG9yeVJlY2VudBIaLmdvb2dsZS5wcm90b2J1",
          "Zi5UaW1lc3RhbXAaEi5SZXBlYXRlZEV4ZXJjaXNlcxI0ChVHZXRFeGVyY2lz",
          "ZUhpc3RvcnlBbGwSDi5FeGVyY2lzZS5UeXBlGgkuRXhlcmNpc2UwAWIGcHJv",
          "dG8z"));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.EmptyReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, },
        new pbr::GeneratedClrTypeInfo(new[] {typeof(global::WorkoutState), typeof(global::ExerciseType), typeof(global::UnitsMassType), }, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::Workout), global::Workout.Parser, new[]{ "Who", "State" }, null, null, null),
          new pbr::GeneratedClrTypeInfo(typeof(global::Exercise), global::Exercise.Parser, new[]{ "Name", "Type", "Set", "Note" }, null, null, new pbr::GeneratedClrTypeInfo[] { new pbr::GeneratedClrTypeInfo(typeof(global::Exercise.Types.Type), global::Exercise.Types.Type.Parser, new[]{ "Name" }, null, null, null)}),
          new pbr::GeneratedClrTypeInfo(typeof(global::RepeatedExercises), global::RepeatedExercises.Parser, new[]{ "Exercise" }, null, null, null),
          new pbr::GeneratedClrTypeInfo(typeof(global::Set), global::Set.Parser, new[]{ "Rep" }, null, null, null),
          new pbr::GeneratedClrTypeInfo(typeof(global::Rep), global::Rep.Parser, new[]{ "Amount", "Weight", "Units" }, null, null, null),
          new pbr::GeneratedClrTypeInfo(typeof(global::User), global::User.Parser, new[]{ "Username" }, null, null, null)
        }));
  }
  #endregion

}
#region Enums
public enum WorkoutState {
  [pbr::OriginalName("START")] Start = 0,
  [pbr::OriginalName("STOP")] Stop = 1,
  [pbr::OriginalName("RESTART")] Restart = 2,
}

public enum ExerciseType {
  [pbr::OriginalName("STRENGTH")] Strength = 0,
  [pbr::OriginalName("CARDIO")] Cardio = 1,
  [pbr::OriginalName("STRETCH")] Stretch = 2,
}

public enum UnitsMassType {
  [pbr::OriginalName("LBS")] Lbs = 0,
  [pbr::OriginalName("POUNDS", PreferredAlias = false)] Pounds = 0,
  [pbr::OriginalName("KG")] Kg = 1,
  [pbr::OriginalName("KILOGRAMS", PreferredAlias = false)] Kilograms = 1,
}

#endregion

#region Messages
/// <summary>
/// ~~~ a Workout session has multiple Exercises done within it. ~~ i mean... from a data MODELLING perspective... but in terms messages...nah?
/// can be used to track starting time when opening app at gym arrival for example
/// used to simply register it is simply active, so that a buddy can join in while one perons's is active.
/// </summary>
public sealed partial class Workout : pb::IMessage<Workout> {
  private static readonly pb::MessageParser<Workout> _parser = new pb::MessageParser<Workout>(() => new Workout());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<Workout> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::EverythingReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public Workout() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public Workout(Workout other) : this() {
    Who = other.who_ != null ? other.Who.Clone() : null;
    state_ = other.state_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public Workout Clone() {
    return new Workout(this);
  }

  /// <summary>Field number for the "who" field.</summary>
  public const int WhoFieldNumber = 1;
  private global::User who_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public global::User Who {
    get { return who_; }
    set {
      who_ = value;
    }
  }

  /// <summary>Field number for the "state" field.</summary>
  public const int StateFieldNumber = 2;
  private global::WorkoutState state_ = 0;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public global::WorkoutState State {
    get { return state_; }
    set {
      state_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as Workout);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(Workout other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (!object.Equals(Who, other.Who)) return false;
    if (State != other.State) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    if (who_ != null) hash ^= Who.GetHashCode();
    if (State != 0) hash ^= State.GetHashCode();
    if (_unknownFields != null) {
      hash ^= _unknownFields.GetHashCode();
    }
    return hash;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override string ToString() {
    return pb::JsonFormatter.ToDiagnosticString(this);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void WriteTo(pb::CodedOutputStream output) {
    if (who_ != null) {
      output.WriteRawTag(10);
      output.WriteMessage(Who);
    }
    if (State != 0) {
      output.WriteRawTag(16);
      output.WriteEnum((int) State);
    }
    if (_unknownFields != null) {
      _unknownFields.WriteTo(output);
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int CalculateSize() {
    int size = 0;
    if (who_ != null) {
      size += 1 + pb::CodedOutputStream.ComputeMessageSize(Who);
    }
    if (State != 0) {
      size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) State);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(Workout other) {
    if (other == null) {
      return;
    }
    if (other.who_ != null) {
      if (who_ == null) {
        who_ = new global::User();
      }
      Who.MergeFrom(other.Who);
    }
    if (other.State != 0) {
      State = other.State;
    }
    _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(pb::CodedInputStream input) {
    uint tag;
    while ((tag = input.ReadTag()) != 0) {
      switch(tag) {
        default:
          _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
          break;
        case 10: {
          if (who_ == null) {
            who_ = new global::User();
          }
          input.ReadMessage(who_);
          break;
        }
        case 16: {
          state_ = (global::WorkoutState) input.ReadEnum();
          break;
        }
      }
    }
  }

}

/// <summary>
/// an Exercise instance, composed of multiple sets
/// </summary>
public sealed partial class Exercise : pb::IMessage<Exercise> {
  private static readonly pb::MessageParser<Exercise> _parser = new pb::MessageParser<Exercise>(() => new Exercise());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<Exercise> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::EverythingReflection.Descriptor.MessageTypes[1]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public Exercise() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public Exercise(Exercise other) : this() {
    name_ = other.name_;
    type_ = other.type_;
    set_ = other.set_.Clone();
    note_ = other.note_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public Exercise Clone() {
    return new Exercise(this);
  }

  /// <summary>Field number for the "name" field.</summary>
  public const int NameFieldNumber = 1;
  private string name_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public string Name {
    get { return name_; }
    set {
      name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  /// <summary>Field number for the "type" field.</summary>
  public const int TypeFieldNumber = 2;
  private global::ExerciseType type_ = 0;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public global::ExerciseType Type {
    get { return type_; }
    set {
      type_ = value;
    }
  }

  /// <summary>Field number for the "set" field.</summary>
  public const int SetFieldNumber = 3;
  private static readonly pb::FieldCodec<global::Set> _repeated_set_codec
      = pb::FieldCodec.ForMessage(26, global::Set.Parser);
  private readonly pbc::RepeatedField<global::Set> set_ = new pbc::RepeatedField<global::Set>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public pbc::RepeatedField<global::Set> Set {
    get { return set_; }
  }

  /// <summary>Field number for the "note" field.</summary>
  public const int NoteFieldNumber = 10;
  private string note_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public string Note {
    get { return note_; }
    set {
      note_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as Exercise);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(Exercise other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (Name != other.Name) return false;
    if (Type != other.Type) return false;
    if(!set_.Equals(other.set_)) return false;
    if (Note != other.Note) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    if (Name.Length != 0) hash ^= Name.GetHashCode();
    if (Type != 0) hash ^= Type.GetHashCode();
    hash ^= set_.GetHashCode();
    if (Note.Length != 0) hash ^= Note.GetHashCode();
    if (_unknownFields != null) {
      hash ^= _unknownFields.GetHashCode();
    }
    return hash;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override string ToString() {
    return pb::JsonFormatter.ToDiagnosticString(this);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void WriteTo(pb::CodedOutputStream output) {
    if (Name.Length != 0) {
      output.WriteRawTag(10);
      output.WriteString(Name);
    }
    if (Type != 0) {
      output.WriteRawTag(16);
      output.WriteEnum((int) Type);
    }
    set_.WriteTo(output, _repeated_set_codec);
    if (Note.Length != 0) {
      output.WriteRawTag(82);
      output.WriteString(Note);
    }
    if (_unknownFields != null) {
      _unknownFields.WriteTo(output);
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int CalculateSize() {
    int size = 0;
    if (Name.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
    }
    if (Type != 0) {
      size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Type);
    }
    size += set_.CalculateSize(_repeated_set_codec);
    if (Note.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(Note);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(Exercise other) {
    if (other == null) {
      return;
    }
    if (other.Name.Length != 0) {
      Name = other.Name;
    }
    if (other.Type != 0) {
      Type = other.Type;
    }
    set_.Add(other.set_);
    if (other.Note.Length != 0) {
      Note = other.Note;
    }
    _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(pb::CodedInputStream input) {
    uint tag;
    while ((tag = input.ReadTag()) != 0) {
      switch(tag) {
        default:
          _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
          break;
        case 10: {
          Name = input.ReadString();
          break;
        }
        case 16: {
          type_ = (global::ExerciseType) input.ReadEnum();
          break;
        }
        case 26: {
          set_.AddEntriesFrom(input, _repeated_set_codec);
          break;
        }
        case 82: {
          Note = input.ReadString();
          break;
        }
      }
    }
  }

  #region Nested types
  /// <summary>Container for nested types declared in the Exercise message type.</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static partial class Types {
    public sealed partial class Type : pb::IMessage<Type> {
      private static readonly pb::MessageParser<Type> _parser = new pb::MessageParser<Type>(() => new Type());
      private pb::UnknownFieldSet _unknownFields;
      [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
      public static pb::MessageParser<Type> Parser { get { return _parser; } }

      [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
      public static pbr::MessageDescriptor Descriptor {
        get { return global::Exercise.Descriptor.NestedTypes[0]; }
      }

      [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
      pbr::MessageDescriptor pb::IMessage.Descriptor {
        get { return Descriptor; }
      }

      [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
      public Type() {
        OnConstruction();
      }

      partial void OnConstruction();

      [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
      public Type(Type other) : this() {
        name_ = other.name_;
        _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
      }

      [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
      public Type Clone() {
        return new Type(this);
      }

      /// <summary>Field number for the "name" field.</summary>
      public const int NameFieldNumber = 1;
      private string name_ = "";
      /// <summary>
      ///todo: resolve my displeasure at having to type in C# redundantly name &amp; type: `new Exercise.Type{ Name = "Bicep Curl"};`
      /// </summary>
      [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
      public string Name {
        get { return name_; }
        set {
          name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
        }
      }

      [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
      public override bool Equals(object other) {
        return Equals(other as Type);
      }

      [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
      public bool Equals(Type other) {
        if (ReferenceEquals(other, null)) {
          return false;
        }
        if (ReferenceEquals(other, this)) {
          return true;
        }
        if (Name != other.Name) return false;
        return Equals(_unknownFields, other._unknownFields);
      }

      [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
      public override int GetHashCode() {
        int hash = 1;
        if (Name.Length != 0) hash ^= Name.GetHashCode();
        if (_unknownFields != null) {
          hash ^= _unknownFields.GetHashCode();
        }
        return hash;
      }

      [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
      public override string ToString() {
        return pb::JsonFormatter.ToDiagnosticString(this);
      }

      [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
      public void WriteTo(pb::CodedOutputStream output) {
        if (Name.Length != 0) {
          output.WriteRawTag(10);
          output.WriteString(Name);
        }
        if (_unknownFields != null) {
          _unknownFields.WriteTo(output);
        }
      }

      [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
      public int CalculateSize() {
        int size = 0;
        if (Name.Length != 0) {
          size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
        }
        if (_unknownFields != null) {
          size += _unknownFields.CalculateSize();
        }
        return size;
      }

      [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
      public void MergeFrom(Type other) {
        if (other == null) {
          return;
        }
        if (other.Name.Length != 0) {
          Name = other.Name;
        }
        _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
      }

      [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
      public void MergeFrom(pb::CodedInputStream input) {
        uint tag;
        while ((tag = input.ReadTag()) != 0) {
          switch(tag) {
            default:
              _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
              break;
            case 10: {
              Name = input.ReadString();
              break;
            }
          }
        }
      }

    }

  }
  #endregion

}

public sealed partial class RepeatedExercises : pb::IMessage<RepeatedExercises> {
  private static readonly pb::MessageParser<RepeatedExercises> _parser = new pb::MessageParser<RepeatedExercises>(() => new RepeatedExercises());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<RepeatedExercises> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::EverythingReflection.Descriptor.MessageTypes[2]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public RepeatedExercises() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public RepeatedExercises(RepeatedExercises other) : this() {
    exercise_ = other.exercise_.Clone();
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public RepeatedExercises Clone() {
    return new RepeatedExercises(this);
  }

  /// <summary>Field number for the "exercise" field.</summary>
  public const int ExerciseFieldNumber = 1;
  private static readonly pb::FieldCodec<global::Exercise> _repeated_exercise_codec
      = pb::FieldCodec.ForMessage(10, global::Exercise.Parser);
  private readonly pbc::RepeatedField<global::Exercise> exercise_ = new pbc::RepeatedField<global::Exercise>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public pbc::RepeatedField<global::Exercise> Exercise {
    get { return exercise_; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as RepeatedExercises);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(RepeatedExercises other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if(!exercise_.Equals(other.exercise_)) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    hash ^= exercise_.GetHashCode();
    if (_unknownFields != null) {
      hash ^= _unknownFields.GetHashCode();
    }
    return hash;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override string ToString() {
    return pb::JsonFormatter.ToDiagnosticString(this);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void WriteTo(pb::CodedOutputStream output) {
    exercise_.WriteTo(output, _repeated_exercise_codec);
    if (_unknownFields != null) {
      _unknownFields.WriteTo(output);
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int CalculateSize() {
    int size = 0;
    size += exercise_.CalculateSize(_repeated_exercise_codec);
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(RepeatedExercises other) {
    if (other == null) {
      return;
    }
    exercise_.Add(other.exercise_);
    _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(pb::CodedInputStream input) {
    uint tag;
    while ((tag = input.ReadTag()) != 0) {
      switch(tag) {
        default:
          _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
          break;
        case 10: {
          exercise_.AddEntriesFrom(input, _repeated_exercise_codec);
          break;
        }
      }
    }
  }

}

/// <summary>
///todo: decide a guid stategy. roughly, i want individual reps to be reconstructable in order without sets. ditto up a level of abstraction... tbd how.
///todo: decide how to handle either A) aborted reps after 0 or 1, and B) how to handle simplist scenarios that don't require this much granular detail
/// </summary>
public sealed partial class Set : pb::IMessage<Set> {
  private static readonly pb::MessageParser<Set> _parser = new pb::MessageParser<Set>(() => new Set());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<Set> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::EverythingReflection.Descriptor.MessageTypes[3]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public Set() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public Set(Set other) : this() {
    rep_ = other.rep_.Clone();
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public Set Clone() {
    return new Set(this);
  }

  /// <summary>Field number for the "rep" field.</summary>
  public const int RepFieldNumber = 1;
  private static readonly pb::FieldCodec<global::Rep> _repeated_rep_codec
      = pb::FieldCodec.ForMessage(10, global::Rep.Parser);
  private readonly pbc::RepeatedField<global::Rep> rep_ = new pbc::RepeatedField<global::Rep>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public pbc::RepeatedField<global::Rep> Rep {
    get { return rep_; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as Set);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(Set other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if(!rep_.Equals(other.rep_)) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    hash ^= rep_.GetHashCode();
    if (_unknownFields != null) {
      hash ^= _unknownFields.GetHashCode();
    }
    return hash;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override string ToString() {
    return pb::JsonFormatter.ToDiagnosticString(this);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void WriteTo(pb::CodedOutputStream output) {
    rep_.WriteTo(output, _repeated_rep_codec);
    if (_unknownFields != null) {
      _unknownFields.WriteTo(output);
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int CalculateSize() {
    int size = 0;
    size += rep_.CalculateSize(_repeated_rep_codec);
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(Set other) {
    if (other == null) {
      return;
    }
    rep_.Add(other.rep_);
    _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(pb::CodedInputStream input) {
    uint tag;
    while ((tag = input.ReadTag()) != 0) {
      switch(tag) {
        default:
          _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
          break;
        case 10: {
          rep_.AddEntriesFrom(input, _repeated_rep_codec);
          break;
        }
      }
    }
  }

}

public sealed partial class Rep : pb::IMessage<Rep> {
  private static readonly pb::MessageParser<Rep> _parser = new pb::MessageParser<Rep>(() => new Rep());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<Rep> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::EverythingReflection.Descriptor.MessageTypes[4]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public Rep() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public Rep(Rep other) : this() {
    amount_ = other.amount_;
    weight_ = other.weight_;
    units_ = other.units_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public Rep Clone() {
    return new Rep(this);
  }

  /// <summary>Field number for the "amount" field.</summary>
  public const int AmountFieldNumber = 1;
  private int amount_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int Amount {
    get { return amount_; }
    set {
      amount_ = value;
    }
  }

  /// <summary>Field number for the "weight" field.</summary>
  public const int WeightFieldNumber = 2;
  private int weight_;
  /// <summary>
  /// named as used in the convential sense, but his really means mass not weight technically.
  /// </summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int Weight {
    get { return weight_; }
    set {
      weight_ = value;
    }
  }

  /// <summary>Field number for the "units" field.</summary>
  public const int UnitsFieldNumber = 3;
  private global::UnitsMassType units_ = 0;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public global::UnitsMassType Units {
    get { return units_; }
    set {
      units_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as Rep);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(Rep other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (Amount != other.Amount) return false;
    if (Weight != other.Weight) return false;
    if (Units != other.Units) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    if (Amount != 0) hash ^= Amount.GetHashCode();
    if (Weight != 0) hash ^= Weight.GetHashCode();
    if (Units != 0) hash ^= Units.GetHashCode();
    if (_unknownFields != null) {
      hash ^= _unknownFields.GetHashCode();
    }
    return hash;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override string ToString() {
    return pb::JsonFormatter.ToDiagnosticString(this);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void WriteTo(pb::CodedOutputStream output) {
    if (Amount != 0) {
      output.WriteRawTag(8);
      output.WriteInt32(Amount);
    }
    if (Weight != 0) {
      output.WriteRawTag(16);
      output.WriteInt32(Weight);
    }
    if (Units != 0) {
      output.WriteRawTag(24);
      output.WriteEnum((int) Units);
    }
    if (_unknownFields != null) {
      _unknownFields.WriteTo(output);
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int CalculateSize() {
    int size = 0;
    if (Amount != 0) {
      size += 1 + pb::CodedOutputStream.ComputeInt32Size(Amount);
    }
    if (Weight != 0) {
      size += 1 + pb::CodedOutputStream.ComputeInt32Size(Weight);
    }
    if (Units != 0) {
      size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Units);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(Rep other) {
    if (other == null) {
      return;
    }
    if (other.Amount != 0) {
      Amount = other.Amount;
    }
    if (other.Weight != 0) {
      Weight = other.Weight;
    }
    if (other.Units != 0) {
      Units = other.Units;
    }
    _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(pb::CodedInputStream input) {
    uint tag;
    while ((tag = input.ReadTag()) != 0) {
      switch(tag) {
        default:
          _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
          break;
        case 8: {
          Amount = input.ReadInt32();
          break;
        }
        case 16: {
          Weight = input.ReadInt32();
          break;
        }
        case 24: {
          units_ = (global::UnitsMassType) input.ReadEnum();
          break;
        }
      }
    }
  }

}

/// <summary>
/// for authentication... todo: investigate possibly replace grpc message User with superior authentication later? 
/// for buddy matching...
/// </summary>
public sealed partial class User : pb::IMessage<User> {
  private static readonly pb::MessageParser<User> _parser = new pb::MessageParser<User>(() => new User());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<User> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::EverythingReflection.Descriptor.MessageTypes[5]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public User() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public User(User other) : this() {
    username_ = other.username_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public User Clone() {
    return new User(this);
  }

  /// <summary>Field number for the "username" field.</summary>
  public const int UsernameFieldNumber = 1;
  private string username_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public string Username {
    get { return username_; }
    set {
      username_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as User);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(User other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (Username != other.Username) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    if (Username.Length != 0) hash ^= Username.GetHashCode();
    if (_unknownFields != null) {
      hash ^= _unknownFields.GetHashCode();
    }
    return hash;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override string ToString() {
    return pb::JsonFormatter.ToDiagnosticString(this);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void WriteTo(pb::CodedOutputStream output) {
    if (Username.Length != 0) {
      output.WriteRawTag(10);
      output.WriteString(Username);
    }
    if (_unknownFields != null) {
      _unknownFields.WriteTo(output);
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int CalculateSize() {
    int size = 0;
    if (Username.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(Username);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(User other) {
    if (other == null) {
      return;
    }
    if (other.Username.Length != 0) {
      Username = other.Username;
    }
    _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(pb::CodedInputStream input) {
    uint tag;
    while ((tag = input.ReadTag()) != 0) {
      switch(tag) {
        default:
          _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
          break;
        case 10: {
          Username = input.ReadString();
          break;
        }
      }
    }
  }

}

#endregion


#endregion Designer generated code