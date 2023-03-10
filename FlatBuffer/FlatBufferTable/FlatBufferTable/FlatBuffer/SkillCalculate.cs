// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_SkillCalculate : Table {
  public static FB_SkillCalculate GetRootAsFB_SkillCalculate(ByteBuffer _bb) { return GetRootAsFB_SkillCalculate(_bb, new FB_SkillCalculate()); }
  public static FB_SkillCalculate GetRootAsFB_SkillCalculate(ByteBuffer _bb, FB_SkillCalculate obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_SkillCalculate __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int BaseValue { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int MaxBaseVal { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int MandomWeight { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int SkillExId { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int SkillLevelValue { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int TheurgyLevelValue { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int MaxTheurgyLevelVal { get { int o = __offset(18); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }

  public static Offset<FB_SkillCalculate> CreateFB_SkillCalculate(FlatBufferBuilder builder,
      int ID = 0,
      int BaseValue = 0,
      int MaxBaseVal = 0,
      int MandomWeight = 0,
      int SkillExId = 0,
      int SkillLevelValue = 0,
      int TheurgyLevelValue = 0,
      int MaxTheurgyLevelVal = 0) {
    builder.StartObject(8);
    FB_SkillCalculate.AddMaxTheurgyLevelVal(builder, MaxTheurgyLevelVal);
    FB_SkillCalculate.AddTheurgyLevelValue(builder, TheurgyLevelValue);
    FB_SkillCalculate.AddSkillLevelValue(builder, SkillLevelValue);
    FB_SkillCalculate.AddSkillExId(builder, SkillExId);
    FB_SkillCalculate.AddMandomWeight(builder, MandomWeight);
    FB_SkillCalculate.AddMaxBaseVal(builder, MaxBaseVal);
    FB_SkillCalculate.AddBaseValue(builder, BaseValue);
    FB_SkillCalculate.AddID(builder, ID);
    return FB_SkillCalculate.EndFB_SkillCalculate(builder);
  }

  public static void StartFB_SkillCalculate(FlatBufferBuilder builder) { builder.StartObject(8); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddBaseValue(FlatBufferBuilder builder, int BaseValue) { builder.AddInt(1, BaseValue, 0); }
  public static void AddMaxBaseVal(FlatBufferBuilder builder, int MaxBaseVal) { builder.AddInt(2, MaxBaseVal, 0); }
  public static void AddMandomWeight(FlatBufferBuilder builder, int MandomWeight) { builder.AddInt(3, MandomWeight, 0); }
  public static void AddSkillExId(FlatBufferBuilder builder, int SkillExId) { builder.AddInt(4, SkillExId, 0); }
  public static void AddSkillLevelValue(FlatBufferBuilder builder, int SkillLevelValue) { builder.AddInt(5, SkillLevelValue, 0); }
  public static void AddTheurgyLevelValue(FlatBufferBuilder builder, int TheurgyLevelValue) { builder.AddInt(6, TheurgyLevelValue, 0); }
  public static void AddMaxTheurgyLevelVal(FlatBufferBuilder builder, int MaxTheurgyLevelVal) { builder.AddInt(7, MaxTheurgyLevelVal, 0); }
  public static Offset<FB_SkillCalculate> EndFB_SkillCalculate(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_SkillCalculate>(o);
  }
};

public sealed class FB_SkillCalculateContainer : Table {
  public static FB_SkillCalculateContainer GetRootAsFB_SkillCalculateContainer(ByteBuffer _bb) { return GetRootAsFB_SkillCalculateContainer(_bb, new FB_SkillCalculateContainer()); }
  public static FB_SkillCalculateContainer GetRootAsFB_SkillCalculateContainer(ByteBuffer _bb, FB_SkillCalculateContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_SkillCalculateContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_SkillCalculateContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_SkillCalculate GetItems(int j) { return GetItems(new FB_SkillCalculate(), j); }
  public FB_SkillCalculate GetItems(FB_SkillCalculate obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_SkillCalculateContainer> CreateFB_SkillCalculateContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_SkillCalculateContainer.AddItems(builder, items);
    return FB_SkillCalculateContainer.EndFB_SkillCalculateContainer(builder);
  }

  public static void StartFB_SkillCalculateContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_SkillCalculate>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_SkillCalculateContainer> EndFB_SkillCalculateContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_SkillCalculateContainer>(o);
  }
  public static void FinishFB_SkillCalculateContainerBuffer(FlatBufferBuilder builder, Offset<FB_SkillCalculateContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
