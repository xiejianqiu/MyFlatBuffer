// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_GuildFormationType : Table {
  public static FB_GuildFormationType GetRootAsFB_GuildFormationType(ByteBuffer _bb) { return GetRootAsFB_GuildFormationType(_bb, new FB_GuildFormationType()); }
  public static FB_GuildFormationType GetRootAsFB_GuildFormationType(ByteBuffer _bb, FB_GuildFormationType obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_GuildFormationType __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Name { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public string Icon { get { int o = __offset(8); return o != 0 ? __string(o + bb_pos) : null; } }
  public int FormationDesc { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int AttrDesc { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_GuildFormationType> CreateFB_GuildFormationType(FlatBufferBuilder builder,
      int Id = 0,
      StringOffset Name = default(StringOffset),
      StringOffset Icon = default(StringOffset),
      int FormationDesc = -1,
      int AttrDesc = -1) {
    builder.StartObject(5);
    FB_GuildFormationType.AddAttrDesc(builder, AttrDesc);
    FB_GuildFormationType.AddFormationDesc(builder, FormationDesc);
    FB_GuildFormationType.AddIcon(builder, Icon);
    FB_GuildFormationType.AddName(builder, Name);
    FB_GuildFormationType.AddId(builder, Id);
    return FB_GuildFormationType.EndFB_GuildFormationType(builder);
  }

  public static void StartFB_GuildFormationType(FlatBufferBuilder builder) { builder.StartObject(5); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(1, NameOffset.Value, 0); }
  public static void AddIcon(FlatBufferBuilder builder, StringOffset IconOffset) { builder.AddOffset(2, IconOffset.Value, 0); }
  public static void AddFormationDesc(FlatBufferBuilder builder, int FormationDesc) { builder.AddInt(3, FormationDesc, -1); }
  public static void AddAttrDesc(FlatBufferBuilder builder, int AttrDesc) { builder.AddInt(4, AttrDesc, -1); }
  public static Offset<FB_GuildFormationType> EndFB_GuildFormationType(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_GuildFormationType>(o);
  }
};

public sealed class FB_GuildFormationTypeContainer : Table {
  public static FB_GuildFormationTypeContainer GetRootAsFB_GuildFormationTypeContainer(ByteBuffer _bb) { return GetRootAsFB_GuildFormationTypeContainer(_bb, new FB_GuildFormationTypeContainer()); }
  public static FB_GuildFormationTypeContainer GetRootAsFB_GuildFormationTypeContainer(ByteBuffer _bb, FB_GuildFormationTypeContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_GuildFormationTypeContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_GuildFormationTypeContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_GuildFormationType GetItems(int j) { return GetItems(new FB_GuildFormationType(), j); }
  public FB_GuildFormationType GetItems(FB_GuildFormationType obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_GuildFormationTypeContainer> CreateFB_GuildFormationTypeContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_GuildFormationTypeContainer.AddItems(builder, items);
    return FB_GuildFormationTypeContainer.EndFB_GuildFormationTypeContainer(builder);
  }

  public static void StartFB_GuildFormationTypeContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_GuildFormationType>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_GuildFormationTypeContainer> EndFB_GuildFormationTypeContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_GuildFormationTypeContainer>(o);
  }
  public static void FinishFB_GuildFormationTypeContainerBuffer(FlatBufferBuilder builder, Offset<FB_GuildFormationTypeContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
