// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_FittingBase : Table {
  public static FB_FittingBase GetRootAsFB_FittingBase(ByteBuffer _bb) { return GetRootAsFB_FittingBase(_bb, new FB_FittingBase()); }
  public static FB_FittingBase GetRootAsFB_FittingBase(ByteBuffer _bb, FB_FittingBase obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_FittingBase __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Name { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public int Type { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int TypeID { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Unlock { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int UnlockParam { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int ItemID { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public float Distance { get { int o = __offset(18); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public float Down { get { int o = __offset(20); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public float Xangle { get { int o = __offset(22); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public float Yangle { get { int o = __offset(24); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public int DescId { get { int o = __offset(26); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int SortId { get { int o = __offset(28); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public bool Appearance { get { int o = __offset(30); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)true; } }

  public static Offset<FB_FittingBase> CreateFB_FittingBase(FlatBufferBuilder builder,
      int Id = 0,
      StringOffset Name = default(StringOffset),
      int Type = -1,
      int TypeID = -1,
      int Unlock = -1,
      int UnlockParam = -1,
      int ItemID = -1,
      float Distance = 0,
      float Down = 0,
      float Xangle = 0,
      float Yangle = 0,
      int DescId = 0,
      int SortId = -1,
      bool Appearance = true) {
    builder.StartObject(14);
    FB_FittingBase.AddSortId(builder, SortId);
    FB_FittingBase.AddDescId(builder, DescId);
    FB_FittingBase.AddYangle(builder, Yangle);
    FB_FittingBase.AddXangle(builder, Xangle);
    FB_FittingBase.AddDown(builder, Down);
    FB_FittingBase.AddDistance(builder, Distance);
    FB_FittingBase.AddItemID(builder, ItemID);
    FB_FittingBase.AddUnlockParam(builder, UnlockParam);
    FB_FittingBase.AddUnlock(builder, Unlock);
    FB_FittingBase.AddTypeID(builder, TypeID);
    FB_FittingBase.AddType(builder, Type);
    FB_FittingBase.AddName(builder, Name);
    FB_FittingBase.AddId(builder, Id);
    FB_FittingBase.AddAppearance(builder, Appearance);
    return FB_FittingBase.EndFB_FittingBase(builder);
  }

  public static void StartFB_FittingBase(FlatBufferBuilder builder) { builder.StartObject(14); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(1, NameOffset.Value, 0); }
  public static void AddType(FlatBufferBuilder builder, int Type) { builder.AddInt(2, Type, -1); }
  public static void AddTypeID(FlatBufferBuilder builder, int TypeID) { builder.AddInt(3, TypeID, -1); }
  public static void AddUnlock(FlatBufferBuilder builder, int Unlock) { builder.AddInt(4, Unlock, -1); }
  public static void AddUnlockParam(FlatBufferBuilder builder, int UnlockParam) { builder.AddInt(5, UnlockParam, -1); }
  public static void AddItemID(FlatBufferBuilder builder, int ItemID) { builder.AddInt(6, ItemID, -1); }
  public static void AddDistance(FlatBufferBuilder builder, float Distance) { builder.AddFloat(7, Distance, 0); }
  public static void AddDown(FlatBufferBuilder builder, float Down) { builder.AddFloat(8, Down, 0); }
  public static void AddXangle(FlatBufferBuilder builder, float Xangle) { builder.AddFloat(9, Xangle, 0); }
  public static void AddYangle(FlatBufferBuilder builder, float Yangle) { builder.AddFloat(10, Yangle, 0); }
  public static void AddDescId(FlatBufferBuilder builder, int DescId) { builder.AddInt(11, DescId, 0); }
  public static void AddSortId(FlatBufferBuilder builder, int SortId) { builder.AddInt(12, SortId, -1); }
  public static void AddAppearance(FlatBufferBuilder builder, bool Appearance) { builder.AddBool(13, Appearance, true); }
  public static Offset<FB_FittingBase> EndFB_FittingBase(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_FittingBase>(o);
  }
};

public sealed class FB_FittingBaseContainer : Table {
  public static FB_FittingBaseContainer GetRootAsFB_FittingBaseContainer(ByteBuffer _bb) { return GetRootAsFB_FittingBaseContainer(_bb, new FB_FittingBaseContainer()); }
  public static FB_FittingBaseContainer GetRootAsFB_FittingBaseContainer(ByteBuffer _bb, FB_FittingBaseContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_FittingBaseContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_FittingBaseContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_FittingBase GetItems(int j) { return GetItems(new FB_FittingBase(), j); }
  public FB_FittingBase GetItems(FB_FittingBase obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_FittingBaseContainer> CreateFB_FittingBaseContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_FittingBaseContainer.AddItems(builder, items);
    return FB_FittingBaseContainer.EndFB_FittingBaseContainer(builder);
  }

  public static void StartFB_FittingBaseContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_FittingBase>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_FittingBaseContainer> EndFB_FittingBaseContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_FittingBaseContainer>(o);
  }
  public static void FinishFB_FittingBaseContainerBuffer(FlatBufferBuilder builder, Offset<FB_FittingBaseContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
