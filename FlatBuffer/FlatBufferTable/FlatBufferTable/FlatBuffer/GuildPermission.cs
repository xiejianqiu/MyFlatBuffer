// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_GuildPermission : Table {
  public static FB_GuildPermission GetRootAsFB_GuildPermission(ByteBuffer _bb) { return GetRootAsFB_GuildPermission(_bb, new FB_GuildPermission()); }
  public static FB_GuildPermission GetRootAsFB_GuildPermission(ByteBuffer _bb, FB_GuildPermission obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_GuildPermission __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Name { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public bool GetPermissionList(int j) { int o = __offset(8); return o != 0 ? 0!=bb.Get(__vector(o) + j * 1) : false; }
  public int PermissionListLength { get { int o = __offset(8); return o != 0 ? __vector_len(o) : 0; } }
  public float DividendRate { get { int o = __offset(10); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }

  public static Offset<FB_GuildPermission> CreateFB_GuildPermission(FlatBufferBuilder builder,
      int Id = 0,
      StringOffset Name = default(StringOffset),
      VectorOffset PermissionList = default(VectorOffset),
      float DividendRate = 0) {
    builder.StartObject(4);
    FB_GuildPermission.AddDividendRate(builder, DividendRate);
    FB_GuildPermission.AddPermissionList(builder, PermissionList);
    FB_GuildPermission.AddName(builder, Name);
    FB_GuildPermission.AddId(builder, Id);
    return FB_GuildPermission.EndFB_GuildPermission(builder);
  }

  public static void StartFB_GuildPermission(FlatBufferBuilder builder) { builder.StartObject(4); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(1, NameOffset.Value, 0); }
  public static void AddPermissionList(FlatBufferBuilder builder, VectorOffset PermissionListOffset) { builder.AddOffset(2, PermissionListOffset.Value, 0); }
  public static VectorOffset CreatePermissionListVector(FlatBufferBuilder builder, bool[] data) { builder.StartVector(1, data.Length, 1); for (int i = data.Length - 1; i >= 0; i--) builder.AddBool(data[i]); return builder.EndVector(); }
  public static void StartPermissionListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(1, numElems, 1); }
  public static void AddDividendRate(FlatBufferBuilder builder, float DividendRate) { builder.AddFloat(3, DividendRate, 0); }
  public static Offset<FB_GuildPermission> EndFB_GuildPermission(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_GuildPermission>(o);
  }
};

public sealed class FB_GuildPermissionContainer : Table {
  public static FB_GuildPermissionContainer GetRootAsFB_GuildPermissionContainer(ByteBuffer _bb) { return GetRootAsFB_GuildPermissionContainer(_bb, new FB_GuildPermissionContainer()); }
  public static FB_GuildPermissionContainer GetRootAsFB_GuildPermissionContainer(ByteBuffer _bb, FB_GuildPermissionContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_GuildPermissionContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_GuildPermissionContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_GuildPermission GetItems(int j) { return GetItems(new FB_GuildPermission(), j); }
  public FB_GuildPermission GetItems(FB_GuildPermission obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_GuildPermissionContainer> CreateFB_GuildPermissionContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_GuildPermissionContainer.AddItems(builder, items);
    return FB_GuildPermissionContainer.EndFB_GuildPermissionContainer(builder);
  }

  public static void StartFB_GuildPermissionContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_GuildPermission>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_GuildPermissionContainer> EndFB_GuildPermissionContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_GuildPermissionContainer>(o);
  }
  public static void FinishFB_GuildPermissionContainerBuffer(FlatBufferBuilder builder, Offset<FB_GuildPermissionContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
