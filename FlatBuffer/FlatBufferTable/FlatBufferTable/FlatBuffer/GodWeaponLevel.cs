// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_GodWeaponLevel : Table {
  public static FB_GodWeaponLevel GetRootAsFB_GodWeaponLevel(ByteBuffer _bb) { return GetRootAsFB_GodWeaponLevel(_bb, new FB_GodWeaponLevel()); }
  public static FB_GodWeaponLevel GetRootAsFB_GodWeaponLevel(ByteBuffer _bb, FB_GodWeaponLevel obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_GodWeaponLevel __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int Exp { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetAttrIDList(int j) { int o = __offset(8); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrIDListLength { get { int o = __offset(8); return o != 0 ? __vector_len(o) : 0; } }
  public int GetAttrValueList(int j) { int o = __offset(10); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrValueListLength { get { int o = __offset(10); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_GodWeaponLevel> CreateFB_GodWeaponLevel(FlatBufferBuilder builder,
      int ID = 0,
      int Exp = -1,
      VectorOffset AttrIDList = default(VectorOffset),
      VectorOffset AttrValueList = default(VectorOffset)) {
    builder.StartObject(4);
    FB_GodWeaponLevel.AddAttrValueList(builder, AttrValueList);
    FB_GodWeaponLevel.AddAttrIDList(builder, AttrIDList);
    FB_GodWeaponLevel.AddExp(builder, Exp);
    FB_GodWeaponLevel.AddID(builder, ID);
    return FB_GodWeaponLevel.EndFB_GodWeaponLevel(builder);
  }

  public static void StartFB_GodWeaponLevel(FlatBufferBuilder builder) { builder.StartObject(4); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddExp(FlatBufferBuilder builder, int Exp) { builder.AddInt(1, Exp, -1); }
  public static void AddAttrIDList(FlatBufferBuilder builder, VectorOffset AttrIDListOffset) { builder.AddOffset(2, AttrIDListOffset.Value, 0); }
  public static VectorOffset CreateAttrIDListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrIDListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddAttrValueList(FlatBufferBuilder builder, VectorOffset AttrValueListOffset) { builder.AddOffset(3, AttrValueListOffset.Value, 0); }
  public static VectorOffset CreateAttrValueListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrValueListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_GodWeaponLevel> EndFB_GodWeaponLevel(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_GodWeaponLevel>(o);
  }
};

public sealed class FB_GodWeaponLevelContainer : Table {
  public static FB_GodWeaponLevelContainer GetRootAsFB_GodWeaponLevelContainer(ByteBuffer _bb) { return GetRootAsFB_GodWeaponLevelContainer(_bb, new FB_GodWeaponLevelContainer()); }
  public static FB_GodWeaponLevelContainer GetRootAsFB_GodWeaponLevelContainer(ByteBuffer _bb, FB_GodWeaponLevelContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_GodWeaponLevelContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_GodWeaponLevelContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_GodWeaponLevel GetItems(int j) { return GetItems(new FB_GodWeaponLevel(), j); }
  public FB_GodWeaponLevel GetItems(FB_GodWeaponLevel obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_GodWeaponLevelContainer> CreateFB_GodWeaponLevelContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_GodWeaponLevelContainer.AddItems(builder, items);
    return FB_GodWeaponLevelContainer.EndFB_GodWeaponLevelContainer(builder);
  }

  public static void StartFB_GodWeaponLevelContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_GodWeaponLevel>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_GodWeaponLevelContainer> EndFB_GodWeaponLevelContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_GodWeaponLevelContainer>(o);
  }
  public static void FinishFB_GodWeaponLevelContainerBuffer(FlatBufferBuilder builder, Offset<FB_GodWeaponLevelContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
