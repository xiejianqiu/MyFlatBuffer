// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_StarCraftFight : Table {
  public static FB_StarCraftFight GetRootAsFB_StarCraftFight(ByteBuffer _bb) { return GetRootAsFB_StarCraftFight(_bb, new FB_StarCraftFight()); }
  public static FB_StarCraftFight GetRootAsFB_StarCraftFight(ByteBuffer _bb, FB_StarCraftFight obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_StarCraftFight __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int CrossWorldLv { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int StarType { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public string Power { get { int o = __offset(10); return o != 0 ? __string(o + bb_pos) : null; } }
  public int MonsterLv { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int CopyScene { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetSpecialAttrList(int j) { int o = __offset(16); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int SpecialAttrListLength { get { int o = __offset(16); return o != 0 ? __vector_len(o) : 0; } }
  public int GetSpecialAttrNumList(int j) { int o = __offset(18); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int SpecialAttrNumListLength { get { int o = __offset(18); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_StarCraftFight> CreateFB_StarCraftFight(FlatBufferBuilder builder,
      int ID = 0,
      int CrossWorldLv = -1,
      int StarType = -1,
      StringOffset Power = default(StringOffset),
      int MonsterLv = -1,
      int CopyScene = -1,
      VectorOffset SpecialAttrList = default(VectorOffset),
      VectorOffset SpecialAttrNumList = default(VectorOffset)) {
    builder.StartObject(8);
    FB_StarCraftFight.AddSpecialAttrNumList(builder, SpecialAttrNumList);
    FB_StarCraftFight.AddSpecialAttrList(builder, SpecialAttrList);
    FB_StarCraftFight.AddCopyScene(builder, CopyScene);
    FB_StarCraftFight.AddMonsterLv(builder, MonsterLv);
    FB_StarCraftFight.AddPower(builder, Power);
    FB_StarCraftFight.AddStarType(builder, StarType);
    FB_StarCraftFight.AddCrossWorldLv(builder, CrossWorldLv);
    FB_StarCraftFight.AddID(builder, ID);
    return FB_StarCraftFight.EndFB_StarCraftFight(builder);
  }

  public static void StartFB_StarCraftFight(FlatBufferBuilder builder) { builder.StartObject(8); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddCrossWorldLv(FlatBufferBuilder builder, int CrossWorldLv) { builder.AddInt(1, CrossWorldLv, -1); }
  public static void AddStarType(FlatBufferBuilder builder, int StarType) { builder.AddInt(2, StarType, -1); }
  public static void AddPower(FlatBufferBuilder builder, StringOffset PowerOffset) { builder.AddOffset(3, PowerOffset.Value, 0); }
  public static void AddMonsterLv(FlatBufferBuilder builder, int MonsterLv) { builder.AddInt(4, MonsterLv, -1); }
  public static void AddCopyScene(FlatBufferBuilder builder, int CopyScene) { builder.AddInt(5, CopyScene, -1); }
  public static void AddSpecialAttrList(FlatBufferBuilder builder, VectorOffset SpecialAttrListOffset) { builder.AddOffset(6, SpecialAttrListOffset.Value, 0); }
  public static VectorOffset CreateSpecialAttrListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartSpecialAttrListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddSpecialAttrNumList(FlatBufferBuilder builder, VectorOffset SpecialAttrNumListOffset) { builder.AddOffset(7, SpecialAttrNumListOffset.Value, 0); }
  public static VectorOffset CreateSpecialAttrNumListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartSpecialAttrNumListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_StarCraftFight> EndFB_StarCraftFight(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_StarCraftFight>(o);
  }
};

public sealed class FB_StarCraftFightContainer : Table {
  public static FB_StarCraftFightContainer GetRootAsFB_StarCraftFightContainer(ByteBuffer _bb) { return GetRootAsFB_StarCraftFightContainer(_bb, new FB_StarCraftFightContainer()); }
  public static FB_StarCraftFightContainer GetRootAsFB_StarCraftFightContainer(ByteBuffer _bb, FB_StarCraftFightContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_StarCraftFightContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_StarCraftFightContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_StarCraftFight GetItems(int j) { return GetItems(new FB_StarCraftFight(), j); }
  public FB_StarCraftFight GetItems(FB_StarCraftFight obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_StarCraftFightContainer> CreateFB_StarCraftFightContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_StarCraftFightContainer.AddItems(builder, items);
    return FB_StarCraftFightContainer.EndFB_StarCraftFightContainer(builder);
  }

  public static void StartFB_StarCraftFightContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_StarCraftFight>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_StarCraftFightContainer> EndFB_StarCraftFightContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_StarCraftFightContainer>(o);
  }
  public static void FinishFB_StarCraftFightContainerBuffer(FlatBufferBuilder builder, Offset<FB_StarCraftFightContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
