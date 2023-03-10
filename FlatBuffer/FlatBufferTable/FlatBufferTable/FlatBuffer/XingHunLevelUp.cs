// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_XingHunLevelUp : Table {
  public static FB_XingHunLevelUp GetRootAsFB_XingHunLevelUp(ByteBuffer _bb) { return GetRootAsFB_XingHunLevelUp(_bb, new FB_XingHunLevelUp()); }
  public static FB_XingHunLevelUp GetRootAsFB_XingHunLevelUp(ByteBuffer _bb, FB_XingHunLevelUp obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_XingHunLevelUp __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int EXP { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Step { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public string Icon { get { int o = __offset(10); return o != 0 ? __string(o + bb_pos) : null; } }
  public int SubLevel { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetAttrIdList(int j) { int o = __offset(14); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrIdListLength { get { int o = __offset(14); return o != 0 ? __vector_len(o) : 0; } }
  public int GetAttrValueList(int j) { int o = __offset(16); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrValueListLength { get { int o = __offset(16); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_XingHunLevelUp> CreateFB_XingHunLevelUp(FlatBufferBuilder builder,
      int ID = 0,
      int EXP = -1,
      int Step = -1,
      StringOffset Icon = default(StringOffset),
      int SubLevel = -1,
      VectorOffset AttrIdList = default(VectorOffset),
      VectorOffset AttrValueList = default(VectorOffset)) {
    builder.StartObject(7);
    FB_XingHunLevelUp.AddAttrValueList(builder, AttrValueList);
    FB_XingHunLevelUp.AddAttrIdList(builder, AttrIdList);
    FB_XingHunLevelUp.AddSubLevel(builder, SubLevel);
    FB_XingHunLevelUp.AddIcon(builder, Icon);
    FB_XingHunLevelUp.AddStep(builder, Step);
    FB_XingHunLevelUp.AddEXP(builder, EXP);
    FB_XingHunLevelUp.AddID(builder, ID);
    return FB_XingHunLevelUp.EndFB_XingHunLevelUp(builder);
  }

  public static void StartFB_XingHunLevelUp(FlatBufferBuilder builder) { builder.StartObject(7); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddEXP(FlatBufferBuilder builder, int EXP) { builder.AddInt(1, EXP, -1); }
  public static void AddStep(FlatBufferBuilder builder, int Step) { builder.AddInt(2, Step, -1); }
  public static void AddIcon(FlatBufferBuilder builder, StringOffset IconOffset) { builder.AddOffset(3, IconOffset.Value, 0); }
  public static void AddSubLevel(FlatBufferBuilder builder, int SubLevel) { builder.AddInt(4, SubLevel, -1); }
  public static void AddAttrIdList(FlatBufferBuilder builder, VectorOffset AttrIdListOffset) { builder.AddOffset(5, AttrIdListOffset.Value, 0); }
  public static VectorOffset CreateAttrIdListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrIdListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddAttrValueList(FlatBufferBuilder builder, VectorOffset AttrValueListOffset) { builder.AddOffset(6, AttrValueListOffset.Value, 0); }
  public static VectorOffset CreateAttrValueListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrValueListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_XingHunLevelUp> EndFB_XingHunLevelUp(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_XingHunLevelUp>(o);
  }
};

public sealed class FB_XingHunLevelUpContainer : Table {
  public static FB_XingHunLevelUpContainer GetRootAsFB_XingHunLevelUpContainer(ByteBuffer _bb) { return GetRootAsFB_XingHunLevelUpContainer(_bb, new FB_XingHunLevelUpContainer()); }
  public static FB_XingHunLevelUpContainer GetRootAsFB_XingHunLevelUpContainer(ByteBuffer _bb, FB_XingHunLevelUpContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_XingHunLevelUpContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_XingHunLevelUpContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_XingHunLevelUp GetItems(int j) { return GetItems(new FB_XingHunLevelUp(), j); }
  public FB_XingHunLevelUp GetItems(FB_XingHunLevelUp obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_XingHunLevelUpContainer> CreateFB_XingHunLevelUpContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_XingHunLevelUpContainer.AddItems(builder, items);
    return FB_XingHunLevelUpContainer.EndFB_XingHunLevelUpContainer(builder);
  }

  public static void StartFB_XingHunLevelUpContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_XingHunLevelUp>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_XingHunLevelUpContainer> EndFB_XingHunLevelUpContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_XingHunLevelUpContainer>(o);
  }
  public static void FinishFB_XingHunLevelUpContainerBuffer(FlatBufferBuilder builder, Offset<FB_XingHunLevelUpContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
