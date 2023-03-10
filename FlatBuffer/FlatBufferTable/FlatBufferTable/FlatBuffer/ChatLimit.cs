// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_ChatLimit : Table {
  public static FB_ChatLimit GetRootAsFB_ChatLimit(ByteBuffer _bb) { return GetRootAsFB_ChatLimit(_bb, new FB_ChatLimit()); }
  public static FB_ChatLimit GetRootAsFB_ChatLimit(ByteBuffer _bb, FB_ChatLimit obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_ChatLimit __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Name { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public int LevelLimit { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int TimeLimit { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int ItemLimit { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int UseItemNumber { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int VitalityLimit { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int ReplaceItemId { get { int o = __offset(18); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int ReplaceItemCount { get { int o = __offset(20); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public string FontColor { get { int o = __offset(22); return o != 0 ? __string(o + bb_pos) : null; } }
  public int HighVolLimit { get { int o = __offset(24); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public float MaxSpeechDuration { get { int o = __offset(26); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public int VIPLevel { get { int o = __offset(28); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int VIPTimeLimit { get { int o = __offset(30); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_ChatLimit> CreateFB_ChatLimit(FlatBufferBuilder builder,
      int Id = 0,
      StringOffset Name = default(StringOffset),
      int LevelLimit = -1,
      int TimeLimit = -1,
      int ItemLimit = -1,
      int UseItemNumber = -1,
      int VitalityLimit = -1,
      int ReplaceItemId = -1,
      int ReplaceItemCount = -1,
      StringOffset FontColor = default(StringOffset),
      int HighVolLimit = 0,
      float MaxSpeechDuration = 0,
      int VIPLevel = -1,
      int VIPTimeLimit = -1) {
    builder.StartObject(14);
    FB_ChatLimit.AddVIPTimeLimit(builder, VIPTimeLimit);
    FB_ChatLimit.AddVIPLevel(builder, VIPLevel);
    FB_ChatLimit.AddMaxSpeechDuration(builder, MaxSpeechDuration);
    FB_ChatLimit.AddHighVolLimit(builder, HighVolLimit);
    FB_ChatLimit.AddFontColor(builder, FontColor);
    FB_ChatLimit.AddReplaceItemCount(builder, ReplaceItemCount);
    FB_ChatLimit.AddReplaceItemId(builder, ReplaceItemId);
    FB_ChatLimit.AddVitalityLimit(builder, VitalityLimit);
    FB_ChatLimit.AddUseItemNumber(builder, UseItemNumber);
    FB_ChatLimit.AddItemLimit(builder, ItemLimit);
    FB_ChatLimit.AddTimeLimit(builder, TimeLimit);
    FB_ChatLimit.AddLevelLimit(builder, LevelLimit);
    FB_ChatLimit.AddName(builder, Name);
    FB_ChatLimit.AddId(builder, Id);
    return FB_ChatLimit.EndFB_ChatLimit(builder);
  }

  public static void StartFB_ChatLimit(FlatBufferBuilder builder) { builder.StartObject(14); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(1, NameOffset.Value, 0); }
  public static void AddLevelLimit(FlatBufferBuilder builder, int LevelLimit) { builder.AddInt(2, LevelLimit, -1); }
  public static void AddTimeLimit(FlatBufferBuilder builder, int TimeLimit) { builder.AddInt(3, TimeLimit, -1); }
  public static void AddItemLimit(FlatBufferBuilder builder, int ItemLimit) { builder.AddInt(4, ItemLimit, -1); }
  public static void AddUseItemNumber(FlatBufferBuilder builder, int UseItemNumber) { builder.AddInt(5, UseItemNumber, -1); }
  public static void AddVitalityLimit(FlatBufferBuilder builder, int VitalityLimit) { builder.AddInt(6, VitalityLimit, -1); }
  public static void AddReplaceItemId(FlatBufferBuilder builder, int ReplaceItemId) { builder.AddInt(7, ReplaceItemId, -1); }
  public static void AddReplaceItemCount(FlatBufferBuilder builder, int ReplaceItemCount) { builder.AddInt(8, ReplaceItemCount, -1); }
  public static void AddFontColor(FlatBufferBuilder builder, StringOffset FontColorOffset) { builder.AddOffset(9, FontColorOffset.Value, 0); }
  public static void AddHighVolLimit(FlatBufferBuilder builder, int HighVolLimit) { builder.AddInt(10, HighVolLimit, 0); }
  public static void AddMaxSpeechDuration(FlatBufferBuilder builder, float MaxSpeechDuration) { builder.AddFloat(11, MaxSpeechDuration, 0); }
  public static void AddVIPLevel(FlatBufferBuilder builder, int VIPLevel) { builder.AddInt(12, VIPLevel, -1); }
  public static void AddVIPTimeLimit(FlatBufferBuilder builder, int VIPTimeLimit) { builder.AddInt(13, VIPTimeLimit, -1); }
  public static Offset<FB_ChatLimit> EndFB_ChatLimit(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ChatLimit>(o);
  }
};

public sealed class FB_ChatLimitContainer : Table {
  public static FB_ChatLimitContainer GetRootAsFB_ChatLimitContainer(ByteBuffer _bb) { return GetRootAsFB_ChatLimitContainer(_bb, new FB_ChatLimitContainer()); }
  public static FB_ChatLimitContainer GetRootAsFB_ChatLimitContainer(ByteBuffer _bb, FB_ChatLimitContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_ChatLimitContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_ChatLimitContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_ChatLimit GetItems(int j) { return GetItems(new FB_ChatLimit(), j); }
  public FB_ChatLimit GetItems(FB_ChatLimit obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_ChatLimitContainer> CreateFB_ChatLimitContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_ChatLimitContainer.AddItems(builder, items);
    return FB_ChatLimitContainer.EndFB_ChatLimitContainer(builder);
  }

  public static void StartFB_ChatLimitContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_ChatLimit>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_ChatLimitContainer> EndFB_ChatLimitContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ChatLimitContainer>(o);
  }
  public static void FinishFB_ChatLimitContainerBuffer(FlatBufferBuilder builder, Offset<FB_ChatLimitContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
