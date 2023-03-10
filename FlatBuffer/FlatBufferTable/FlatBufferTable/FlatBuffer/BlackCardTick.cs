// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_BlackCardTick : Table {
  public static FB_BlackCardTick GetRootAsFB_BlackCardTick(ByteBuffer _bb) { return GetRootAsFB_BlackCardTick(_bb, new FB_BlackCardTick()); }
  public static FB_BlackCardTick GetRootAsFB_BlackCardTick(ByteBuffer _bb, FB_BlackCardTick obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_BlackCardTick __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Name { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public int ClassID { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int LogicType { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Goal { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetParamList(int j) { int o = __offset(14); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int ParamListLength { get { int o = __offset(14); return o != 0 ? __vector_len(o) : 0; } }
  public int GetBonusIDList(int j) { int o = __offset(16); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int BonusIDListLength { get { int o = __offset(16); return o != 0 ? __vector_len(o) : 0; } }
  public int GetBonusNumList(int j) { int o = __offset(18); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int BonusNumListLength { get { int o = __offset(18); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_BlackCardTick> CreateFB_BlackCardTick(FlatBufferBuilder builder,
      int ID = 0,
      StringOffset Name = default(StringOffset),
      int ClassID = -1,
      int LogicType = -1,
      int Goal = -1,
      VectorOffset ParamList = default(VectorOffset),
      VectorOffset BonusIDList = default(VectorOffset),
      VectorOffset BonusNumList = default(VectorOffset)) {
    builder.StartObject(8);
    FB_BlackCardTick.AddBonusNumList(builder, BonusNumList);
    FB_BlackCardTick.AddBonusIDList(builder, BonusIDList);
    FB_BlackCardTick.AddParamList(builder, ParamList);
    FB_BlackCardTick.AddGoal(builder, Goal);
    FB_BlackCardTick.AddLogicType(builder, LogicType);
    FB_BlackCardTick.AddClassID(builder, ClassID);
    FB_BlackCardTick.AddName(builder, Name);
    FB_BlackCardTick.AddID(builder, ID);
    return FB_BlackCardTick.EndFB_BlackCardTick(builder);
  }

  public static void StartFB_BlackCardTick(FlatBufferBuilder builder) { builder.StartObject(8); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(1, NameOffset.Value, 0); }
  public static void AddClassID(FlatBufferBuilder builder, int ClassID) { builder.AddInt(2, ClassID, -1); }
  public static void AddLogicType(FlatBufferBuilder builder, int LogicType) { builder.AddInt(3, LogicType, -1); }
  public static void AddGoal(FlatBufferBuilder builder, int Goal) { builder.AddInt(4, Goal, -1); }
  public static void AddParamList(FlatBufferBuilder builder, VectorOffset ParamListOffset) { builder.AddOffset(5, ParamListOffset.Value, 0); }
  public static VectorOffset CreateParamListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartParamListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddBonusIDList(FlatBufferBuilder builder, VectorOffset BonusIDListOffset) { builder.AddOffset(6, BonusIDListOffset.Value, 0); }
  public static VectorOffset CreateBonusIDListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartBonusIDListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddBonusNumList(FlatBufferBuilder builder, VectorOffset BonusNumListOffset) { builder.AddOffset(7, BonusNumListOffset.Value, 0); }
  public static VectorOffset CreateBonusNumListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartBonusNumListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_BlackCardTick> EndFB_BlackCardTick(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_BlackCardTick>(o);
  }
};

public sealed class FB_BlackCardTickContainer : Table {
  public static FB_BlackCardTickContainer GetRootAsFB_BlackCardTickContainer(ByteBuffer _bb) { return GetRootAsFB_BlackCardTickContainer(_bb, new FB_BlackCardTickContainer()); }
  public static FB_BlackCardTickContainer GetRootAsFB_BlackCardTickContainer(ByteBuffer _bb, FB_BlackCardTickContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_BlackCardTickContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_BlackCardTickContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_BlackCardTick GetItems(int j) { return GetItems(new FB_BlackCardTick(), j); }
  public FB_BlackCardTick GetItems(FB_BlackCardTick obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_BlackCardTickContainer> CreateFB_BlackCardTickContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_BlackCardTickContainer.AddItems(builder, items);
    return FB_BlackCardTickContainer.EndFB_BlackCardTickContainer(builder);
  }

  public static void StartFB_BlackCardTickContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_BlackCardTick>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_BlackCardTickContainer> EndFB_BlackCardTickContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_BlackCardTickContainer>(o);
  }
  public static void FinishFB_BlackCardTickContainerBuffer(FlatBufferBuilder builder, Offset<FB_BlackCardTickContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
