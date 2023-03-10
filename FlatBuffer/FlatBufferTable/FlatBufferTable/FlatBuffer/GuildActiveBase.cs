// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_GuildActiveBase : Table {
  public static FB_GuildActiveBase GetRootAsFB_GuildActiveBase(ByteBuffer _bb) { return GetRootAsFB_GuildActiveBase(_bb, new FB_GuildActiveBase()); }
  public static FB_GuildActiveBase GetRootAsFB_GuildActiveBase(ByteBuffer _bb, FB_GuildActiveBase obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_GuildActiveBase __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Name { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public string BgSprite { get { int o = __offset(8); return o != 0 ? __string(o + bb_pos) : null; } }
  public string Descript { get { int o = __offset(10); return o != 0 ? __string(o + bb_pos) : null; } }
  public int IconItemId { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string UnlockType { get { int o = __offset(14); return o != 0 ? __string(o + bb_pos) : null; } }
  public string OpenType { get { int o = __offset(16); return o != 0 ? __string(o + bb_pos) : null; } }
  public int TargetType { get { int o = __offset(18); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public float GetTargetParamList(int j) { int o = __offset(20); return o != 0 ? bb.GetFloat(__vector(o) + j * 4) : (float)0; }
  public int TargetParamListLength { get { int o = __offset(20); return o != 0 ? __vector_len(o) : 0; } }
  public int ActivityID { get { int o = __offset(22); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_GuildActiveBase> CreateFB_GuildActiveBase(FlatBufferBuilder builder,
      int Id = 0,
      StringOffset Name = default(StringOffset),
      StringOffset BgSprite = default(StringOffset),
      StringOffset Descript = default(StringOffset),
      int IconItemId = 0,
      StringOffset UnlockType = default(StringOffset),
      StringOffset OpenType = default(StringOffset),
      int TargetType = -1,
      VectorOffset TargetParamList = default(VectorOffset),
      int ActivityID = -1) {
    builder.StartObject(10);
    FB_GuildActiveBase.AddActivityID(builder, ActivityID);
    FB_GuildActiveBase.AddTargetParamList(builder, TargetParamList);
    FB_GuildActiveBase.AddTargetType(builder, TargetType);
    FB_GuildActiveBase.AddOpenType(builder, OpenType);
    FB_GuildActiveBase.AddUnlockType(builder, UnlockType);
    FB_GuildActiveBase.AddIconItemId(builder, IconItemId);
    FB_GuildActiveBase.AddDescript(builder, Descript);
    FB_GuildActiveBase.AddBgSprite(builder, BgSprite);
    FB_GuildActiveBase.AddName(builder, Name);
    FB_GuildActiveBase.AddId(builder, Id);
    return FB_GuildActiveBase.EndFB_GuildActiveBase(builder);
  }

  public static void StartFB_GuildActiveBase(FlatBufferBuilder builder) { builder.StartObject(10); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(1, NameOffset.Value, 0); }
  public static void AddBgSprite(FlatBufferBuilder builder, StringOffset BgSpriteOffset) { builder.AddOffset(2, BgSpriteOffset.Value, 0); }
  public static void AddDescript(FlatBufferBuilder builder, StringOffset DescriptOffset) { builder.AddOffset(3, DescriptOffset.Value, 0); }
  public static void AddIconItemId(FlatBufferBuilder builder, int IconItemId) { builder.AddInt(4, IconItemId, 0); }
  public static void AddUnlockType(FlatBufferBuilder builder, StringOffset UnlockTypeOffset) { builder.AddOffset(5, UnlockTypeOffset.Value, 0); }
  public static void AddOpenType(FlatBufferBuilder builder, StringOffset OpenTypeOffset) { builder.AddOffset(6, OpenTypeOffset.Value, 0); }
  public static void AddTargetType(FlatBufferBuilder builder, int TargetType) { builder.AddInt(7, TargetType, -1); }
  public static void AddTargetParamList(FlatBufferBuilder builder, VectorOffset TargetParamListOffset) { builder.AddOffset(8, TargetParamListOffset.Value, 0); }
  public static VectorOffset CreateTargetParamListVector(FlatBufferBuilder builder, float[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddFloat(data[i]); return builder.EndVector(); }
  public static void StartTargetParamListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddActivityID(FlatBufferBuilder builder, int ActivityID) { builder.AddInt(9, ActivityID, -1); }
  public static Offset<FB_GuildActiveBase> EndFB_GuildActiveBase(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_GuildActiveBase>(o);
  }
};

public sealed class FB_GuildActiveBaseContainer : Table {
  public static FB_GuildActiveBaseContainer GetRootAsFB_GuildActiveBaseContainer(ByteBuffer _bb) { return GetRootAsFB_GuildActiveBaseContainer(_bb, new FB_GuildActiveBaseContainer()); }
  public static FB_GuildActiveBaseContainer GetRootAsFB_GuildActiveBaseContainer(ByteBuffer _bb, FB_GuildActiveBaseContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_GuildActiveBaseContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_GuildActiveBaseContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_GuildActiveBase GetItems(int j) { return GetItems(new FB_GuildActiveBase(), j); }
  public FB_GuildActiveBase GetItems(FB_GuildActiveBase obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_GuildActiveBaseContainer> CreateFB_GuildActiveBaseContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_GuildActiveBaseContainer.AddItems(builder, items);
    return FB_GuildActiveBaseContainer.EndFB_GuildActiveBaseContainer(builder);
  }

  public static void StartFB_GuildActiveBaseContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_GuildActiveBase>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_GuildActiveBaseContainer> EndFB_GuildActiveBaseContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_GuildActiveBaseContainer>(o);
  }
  public static void FinishFB_GuildActiveBaseContainerBuffer(FlatBufferBuilder builder, Offset<FB_GuildActiveBaseContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
