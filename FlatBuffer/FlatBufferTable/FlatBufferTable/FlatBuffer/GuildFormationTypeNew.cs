// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_GuildFormationTypeNew : Table {
  public static FB_GuildFormationTypeNew GetRootAsFB_GuildFormationTypeNew(ByteBuffer _bb) { return GetRootAsFB_GuildFormationTypeNew(_bb, new FB_GuildFormationTypeNew()); }
  public static FB_GuildFormationTypeNew GetRootAsFB_GuildFormationTypeNew(ByteBuffer _bb, FB_GuildFormationTypeNew obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_GuildFormationTypeNew __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Name { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public string Icon { get { int o = __offset(8); return o != 0 ? __string(o + bb_pos) : null; } }
  public int FormationDesc { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int AttrDesc { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int LevelLimit { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_GuildFormationTypeNew> CreateFB_GuildFormationTypeNew(FlatBufferBuilder builder,
      int Id = 0,
      StringOffset Name = default(StringOffset),
      StringOffset Icon = default(StringOffset),
      int FormationDesc = -1,
      int AttrDesc = -1,
      int LevelLimit = -1) {
    builder.StartObject(6);
    FB_GuildFormationTypeNew.AddLevelLimit(builder, LevelLimit);
    FB_GuildFormationTypeNew.AddAttrDesc(builder, AttrDesc);
    FB_GuildFormationTypeNew.AddFormationDesc(builder, FormationDesc);
    FB_GuildFormationTypeNew.AddIcon(builder, Icon);
    FB_GuildFormationTypeNew.AddName(builder, Name);
    FB_GuildFormationTypeNew.AddId(builder, Id);
    return FB_GuildFormationTypeNew.EndFB_GuildFormationTypeNew(builder);
  }

  public static void StartFB_GuildFormationTypeNew(FlatBufferBuilder builder) { builder.StartObject(6); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(1, NameOffset.Value, 0); }
  public static void AddIcon(FlatBufferBuilder builder, StringOffset IconOffset) { builder.AddOffset(2, IconOffset.Value, 0); }
  public static void AddFormationDesc(FlatBufferBuilder builder, int FormationDesc) { builder.AddInt(3, FormationDesc, -1); }
  public static void AddAttrDesc(FlatBufferBuilder builder, int AttrDesc) { builder.AddInt(4, AttrDesc, -1); }
  public static void AddLevelLimit(FlatBufferBuilder builder, int LevelLimit) { builder.AddInt(5, LevelLimit, -1); }
  public static Offset<FB_GuildFormationTypeNew> EndFB_GuildFormationTypeNew(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_GuildFormationTypeNew>(o);
  }
};

public sealed class FB_GuildFormationTypeNewContainer : Table {
  public static FB_GuildFormationTypeNewContainer GetRootAsFB_GuildFormationTypeNewContainer(ByteBuffer _bb) { return GetRootAsFB_GuildFormationTypeNewContainer(_bb, new FB_GuildFormationTypeNewContainer()); }
  public static FB_GuildFormationTypeNewContainer GetRootAsFB_GuildFormationTypeNewContainer(ByteBuffer _bb, FB_GuildFormationTypeNewContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_GuildFormationTypeNewContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_GuildFormationTypeNewContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_GuildFormationTypeNew GetItems(int j) { return GetItems(new FB_GuildFormationTypeNew(), j); }
  public FB_GuildFormationTypeNew GetItems(FB_GuildFormationTypeNew obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_GuildFormationTypeNewContainer> CreateFB_GuildFormationTypeNewContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_GuildFormationTypeNewContainer.AddItems(builder, items);
    return FB_GuildFormationTypeNewContainer.EndFB_GuildFormationTypeNewContainer(builder);
  }

  public static void StartFB_GuildFormationTypeNewContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_GuildFormationTypeNew>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_GuildFormationTypeNewContainer> EndFB_GuildFormationTypeNewContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_GuildFormationTypeNewContainer>(o);
  }
  public static void FinishFB_GuildFormationTypeNewContainerBuffer(FlatBufferBuilder builder, Offset<FB_GuildFormationTypeNewContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
