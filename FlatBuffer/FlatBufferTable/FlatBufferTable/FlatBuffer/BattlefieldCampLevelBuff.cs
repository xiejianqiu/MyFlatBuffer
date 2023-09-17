// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_BattlefieldCampLevelBuff : Table {
  public static FB_BattlefieldCampLevelBuff GetRootAsFB_BattlefieldCampLevelBuff(ByteBuffer _bb) { return GetRootAsFB_BattlefieldCampLevelBuff(_bb, new FB_BattlefieldCampLevelBuff()); }
  public static FB_BattlefieldCampLevelBuff GetRootAsFB_BattlefieldCampLevelBuff(ByteBuffer _bb, FB_BattlefieldCampLevelBuff obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_BattlefieldCampLevelBuff __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int BuildNum { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetIncPercentBufList(int j) { int o = __offset(8); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int IncPercentBufListLength { get { int o = __offset(8); return o != 0 ? __vector_len(o) : 0; } }
  public int GetDelBufList(int j) { int o = __offset(10); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int DelBufListLength { get { int o = __offset(10); return o != 0 ? __vector_len(o) : 0; } }
  public string GetBuffAddList(int j) { int o = __offset(12); return o != 0 ? __string(__vector(o) + j * 4) : null; }
  public int BuffAddListLength { get { int o = __offset(12); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_BattlefieldCampLevelBuff> CreateFB_BattlefieldCampLevelBuff(FlatBufferBuilder builder,
      int ID = 0,
      int BuildNum = -1,
      VectorOffset IncPercentBufList = default(VectorOffset),
      VectorOffset DelBufList = default(VectorOffset),
      VectorOffset BuffAddList = default(VectorOffset)) {
    builder.StartObject(5);
    FB_BattlefieldCampLevelBuff.AddBuffAddList(builder, BuffAddList);
    FB_BattlefieldCampLevelBuff.AddDelBufList(builder, DelBufList);
    FB_BattlefieldCampLevelBuff.AddIncPercentBufList(builder, IncPercentBufList);
    FB_BattlefieldCampLevelBuff.AddBuildNum(builder, BuildNum);
    FB_BattlefieldCampLevelBuff.AddID(builder, ID);
    return FB_BattlefieldCampLevelBuff.EndFB_BattlefieldCampLevelBuff(builder);
  }

  public static void StartFB_BattlefieldCampLevelBuff(FlatBufferBuilder builder) { builder.StartObject(5); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddBuildNum(FlatBufferBuilder builder, int BuildNum) { builder.AddInt(1, BuildNum, -1); }
  public static void AddIncPercentBufList(FlatBufferBuilder builder, VectorOffset IncPercentBufListOffset) { builder.AddOffset(2, IncPercentBufListOffset.Value, 0); }
  public static VectorOffset CreateIncPercentBufListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartIncPercentBufListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddDelBufList(FlatBufferBuilder builder, VectorOffset DelBufListOffset) { builder.AddOffset(3, DelBufListOffset.Value, 0); }
  public static VectorOffset CreateDelBufListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartDelBufListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddBuffAddList(FlatBufferBuilder builder, VectorOffset BuffAddListOffset) { builder.AddOffset(4, BuffAddListOffset.Value, 0); }
  public static VectorOffset CreateBuffAddListVector(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartBuffAddListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_BattlefieldCampLevelBuff> EndFB_BattlefieldCampLevelBuff(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_BattlefieldCampLevelBuff>(o);
  }
};

public sealed class FB_BattlefieldCampLevelBuffContainer : Table {
  public static FB_BattlefieldCampLevelBuffContainer GetRootAsFB_BattlefieldCampLevelBuffContainer(ByteBuffer _bb) { return GetRootAsFB_BattlefieldCampLevelBuffContainer(_bb, new FB_BattlefieldCampLevelBuffContainer()); }
  public static FB_BattlefieldCampLevelBuffContainer GetRootAsFB_BattlefieldCampLevelBuffContainer(ByteBuffer _bb, FB_BattlefieldCampLevelBuffContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_BattlefieldCampLevelBuffContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_BattlefieldCampLevelBuffContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_BattlefieldCampLevelBuff GetItems(int j) { return GetItems(new FB_BattlefieldCampLevelBuff(), j); }
  public FB_BattlefieldCampLevelBuff GetItems(FB_BattlefieldCampLevelBuff obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_BattlefieldCampLevelBuffContainer> CreateFB_BattlefieldCampLevelBuffContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_BattlefieldCampLevelBuffContainer.AddItems(builder, items);
    return FB_BattlefieldCampLevelBuffContainer.EndFB_BattlefieldCampLevelBuffContainer(builder);
  }

  public static void StartFB_BattlefieldCampLevelBuffContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_BattlefieldCampLevelBuff>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_BattlefieldCampLevelBuffContainer> EndFB_BattlefieldCampLevelBuffContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_BattlefieldCampLevelBuffContainer>(o);
  }
  public static void FinishFB_BattlefieldCampLevelBuffContainerBuffer(FlatBufferBuilder builder, Offset<FB_BattlefieldCampLevelBuffContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
