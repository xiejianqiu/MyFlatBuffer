// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_PlayerSkinLevelUp : Table {
  public static FB_PlayerSkinLevelUp GetRootAsFB_PlayerSkinLevelUp(ByteBuffer _bb) { return GetRootAsFB_PlayerSkinLevelUp(_bb, new FB_PlayerSkinLevelUp()); }
  public static FB_PlayerSkinLevelUp GetRootAsFB_PlayerSkinLevelUp(ByteBuffer _bb, FB_PlayerSkinLevelUp obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_PlayerSkinLevelUp __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int Exp { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetAttrIdList(int j) { int o = __offset(8); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrIdListLength { get { int o = __offset(8); return o != 0 ? __vector_len(o) : 0; } }
  public int GetAttrValueList(int j) { int o = __offset(10); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrValueListLength { get { int o = __offset(10); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_PlayerSkinLevelUp> CreateFB_PlayerSkinLevelUp(FlatBufferBuilder builder,
      int ID = 0,
      int Exp = -1,
      VectorOffset AttrIdList = default(VectorOffset),
      VectorOffset AttrValueList = default(VectorOffset)) {
    builder.StartObject(4);
    FB_PlayerSkinLevelUp.AddAttrValueList(builder, AttrValueList);
    FB_PlayerSkinLevelUp.AddAttrIdList(builder, AttrIdList);
    FB_PlayerSkinLevelUp.AddExp(builder, Exp);
    FB_PlayerSkinLevelUp.AddID(builder, ID);
    return FB_PlayerSkinLevelUp.EndFB_PlayerSkinLevelUp(builder);
  }

  public static void StartFB_PlayerSkinLevelUp(FlatBufferBuilder builder) { builder.StartObject(4); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddExp(FlatBufferBuilder builder, int Exp) { builder.AddInt(1, Exp, -1); }
  public static void AddAttrIdList(FlatBufferBuilder builder, VectorOffset AttrIdListOffset) { builder.AddOffset(2, AttrIdListOffset.Value, 0); }
  public static VectorOffset CreateAttrIdListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrIdListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddAttrValueList(FlatBufferBuilder builder, VectorOffset AttrValueListOffset) { builder.AddOffset(3, AttrValueListOffset.Value, 0); }
  public static VectorOffset CreateAttrValueListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrValueListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_PlayerSkinLevelUp> EndFB_PlayerSkinLevelUp(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_PlayerSkinLevelUp>(o);
  }
};

public sealed class FB_PlayerSkinLevelUpContainer : Table {
  public static FB_PlayerSkinLevelUpContainer GetRootAsFB_PlayerSkinLevelUpContainer(ByteBuffer _bb) { return GetRootAsFB_PlayerSkinLevelUpContainer(_bb, new FB_PlayerSkinLevelUpContainer()); }
  public static FB_PlayerSkinLevelUpContainer GetRootAsFB_PlayerSkinLevelUpContainer(ByteBuffer _bb, FB_PlayerSkinLevelUpContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_PlayerSkinLevelUpContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_PlayerSkinLevelUpContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_PlayerSkinLevelUp GetItems(int j) { return GetItems(new FB_PlayerSkinLevelUp(), j); }
  public FB_PlayerSkinLevelUp GetItems(FB_PlayerSkinLevelUp obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_PlayerSkinLevelUpContainer> CreateFB_PlayerSkinLevelUpContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_PlayerSkinLevelUpContainer.AddItems(builder, items);
    return FB_PlayerSkinLevelUpContainer.EndFB_PlayerSkinLevelUpContainer(builder);
  }

  public static void StartFB_PlayerSkinLevelUpContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_PlayerSkinLevelUp>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_PlayerSkinLevelUpContainer> EndFB_PlayerSkinLevelUpContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_PlayerSkinLevelUpContainer>(o);
  }
  public static void FinishFB_PlayerSkinLevelUpContainerBuffer(FlatBufferBuilder builder, Offset<FB_PlayerSkinLevelUpContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
