// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_HunJiangSkillValue : Table {
  public static FB_HunJiangSkillValue GetRootAsFB_HunJiangSkillValue(ByteBuffer _bb) { return GetRootAsFB_HunJiangSkillValue(_bb, new FB_HunJiangSkillValue()); }
  public static FB_HunJiangSkillValue GetRootAsFB_HunJiangSkillValue(ByteBuffer _bb, FB_HunJiangSkillValue obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_HunJiangSkillValue __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Name { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public int Quality { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int RaceRequired { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int PassiveSkillId { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int RateOne { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int RateTwo { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_HunJiangSkillValue> CreateFB_HunJiangSkillValue(FlatBufferBuilder builder,
      int ID = 0,
      StringOffset Name = default(StringOffset),
      int Quality = -1,
      int RaceRequired = -1,
      int PassiveSkillId = -1,
      int RateOne = -1,
      int RateTwo = -1) {
    builder.StartObject(7);
    FB_HunJiangSkillValue.AddRateTwo(builder, RateTwo);
    FB_HunJiangSkillValue.AddRateOne(builder, RateOne);
    FB_HunJiangSkillValue.AddPassiveSkillId(builder, PassiveSkillId);
    FB_HunJiangSkillValue.AddRaceRequired(builder, RaceRequired);
    FB_HunJiangSkillValue.AddQuality(builder, Quality);
    FB_HunJiangSkillValue.AddName(builder, Name);
    FB_HunJiangSkillValue.AddID(builder, ID);
    return FB_HunJiangSkillValue.EndFB_HunJiangSkillValue(builder);
  }

  public static void StartFB_HunJiangSkillValue(FlatBufferBuilder builder) { builder.StartObject(7); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(1, NameOffset.Value, 0); }
  public static void AddQuality(FlatBufferBuilder builder, int Quality) { builder.AddInt(2, Quality, -1); }
  public static void AddRaceRequired(FlatBufferBuilder builder, int RaceRequired) { builder.AddInt(3, RaceRequired, -1); }
  public static void AddPassiveSkillId(FlatBufferBuilder builder, int PassiveSkillId) { builder.AddInt(4, PassiveSkillId, -1); }
  public static void AddRateOne(FlatBufferBuilder builder, int RateOne) { builder.AddInt(5, RateOne, -1); }
  public static void AddRateTwo(FlatBufferBuilder builder, int RateTwo) { builder.AddInt(6, RateTwo, -1); }
  public static Offset<FB_HunJiangSkillValue> EndFB_HunJiangSkillValue(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_HunJiangSkillValue>(o);
  }
};

public sealed class FB_HunJiangSkillValueContainer : Table {
  public static FB_HunJiangSkillValueContainer GetRootAsFB_HunJiangSkillValueContainer(ByteBuffer _bb) { return GetRootAsFB_HunJiangSkillValueContainer(_bb, new FB_HunJiangSkillValueContainer()); }
  public static FB_HunJiangSkillValueContainer GetRootAsFB_HunJiangSkillValueContainer(ByteBuffer _bb, FB_HunJiangSkillValueContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_HunJiangSkillValueContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_HunJiangSkillValueContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_HunJiangSkillValue GetItems(int j) { return GetItems(new FB_HunJiangSkillValue(), j); }
  public FB_HunJiangSkillValue GetItems(FB_HunJiangSkillValue obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_HunJiangSkillValueContainer> CreateFB_HunJiangSkillValueContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_HunJiangSkillValueContainer.AddItems(builder, items);
    return FB_HunJiangSkillValueContainer.EndFB_HunJiangSkillValueContainer(builder);
  }

  public static void StartFB_HunJiangSkillValueContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_HunJiangSkillValue>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_HunJiangSkillValueContainer> EndFB_HunJiangSkillValueContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_HunJiangSkillValueContainer>(o);
  }
  public static void FinishFB_HunJiangSkillValueContainerBuffer(FlatBufferBuilder builder, Offset<FB_HunJiangSkillValueContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
