// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_fwqlist : Table {
  public static FB_fwqlist GetRootAsFB_fwqlist(ByteBuffer _bb) { return GetRootAsFB_fwqlist(_bb, new FB_fwqlist()); }
  public static FB_fwqlist GetRootAsFB_fwqlist(ByteBuffer _bb, FB_fwqlist obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_fwqlist __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string ServerName { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public string Ip { get { int o = __offset(8); return o != 0 ? __string(o + bb_pos) : null; } }
  public int Port { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public long ServerStartTime { get { int o = __offset(12); return o != 0 ? bb.GetLong(o + bb_pos) : (long)0; } }
  public int WorldId { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int ServerState { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int IsTuiJian { get { int o = __offset(18); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int Weight { get { int o = __offset(20); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }

  public static Offset<FB_fwqlist> CreateFB_fwqlist(FlatBufferBuilder builder,
      int Id = 0,
      StringOffset ServerName = default(StringOffset),
      StringOffset Ip = default(StringOffset),
      int Port = 0,
      long ServerStartTime = 0,
      int WorldId = 0,
      int ServerState = 0,
      int IsTuiJian = 0,
      int Weight = 0) {
    builder.StartObject(9);
    FB_fwqlist.AddServerStartTime(builder, ServerStartTime);
    FB_fwqlist.AddWeight(builder, Weight);
    FB_fwqlist.AddIsTuiJian(builder, IsTuiJian);
    FB_fwqlist.AddServerState(builder, ServerState);
    FB_fwqlist.AddWorldId(builder, WorldId);
    FB_fwqlist.AddPort(builder, Port);
    FB_fwqlist.AddIp(builder, Ip);
    FB_fwqlist.AddServerName(builder, ServerName);
    FB_fwqlist.AddId(builder, Id);
    return FB_fwqlist.EndFB_fwqlist(builder);
  }

  public static void StartFB_fwqlist(FlatBufferBuilder builder) { builder.StartObject(9); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddServerName(FlatBufferBuilder builder, StringOffset ServerNameOffset) { builder.AddOffset(1, ServerNameOffset.Value, 0); }
  public static void AddIp(FlatBufferBuilder builder, StringOffset IpOffset) { builder.AddOffset(2, IpOffset.Value, 0); }
  public static void AddPort(FlatBufferBuilder builder, int Port) { builder.AddInt(3, Port, 0); }
  public static void AddServerStartTime(FlatBufferBuilder builder, long ServerStartTime) { builder.AddLong(4, ServerStartTime, 0); }
  public static void AddWorldId(FlatBufferBuilder builder, int WorldId) { builder.AddInt(5, WorldId, 0); }
  public static void AddServerState(FlatBufferBuilder builder, int ServerState) { builder.AddInt(6, ServerState, 0); }
  public static void AddIsTuiJian(FlatBufferBuilder builder, int IsTuiJian) { builder.AddInt(7, IsTuiJian, 0); }
  public static void AddWeight(FlatBufferBuilder builder, int Weight) { builder.AddInt(8, Weight, 0); }
  public static Offset<FB_fwqlist> EndFB_fwqlist(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_fwqlist>(o);
  }
};

public sealed class FB_fwqlistContainer : Table {
  public static FB_fwqlistContainer GetRootAsFB_fwqlistContainer(ByteBuffer _bb) { return GetRootAsFB_fwqlistContainer(_bb, new FB_fwqlistContainer()); }
  public static FB_fwqlistContainer GetRootAsFB_fwqlistContainer(ByteBuffer _bb, FB_fwqlistContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_fwqlistContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_fwqlistContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_fwqlist GetItems(int j) { return GetItems(new FB_fwqlist(), j); }
  public FB_fwqlist GetItems(FB_fwqlist obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_fwqlistContainer> CreateFB_fwqlistContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_fwqlistContainer.AddItems(builder, items);
    return FB_fwqlistContainer.EndFB_fwqlistContainer(builder);
  }

  public static void StartFB_fwqlistContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_fwqlist>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_fwqlistContainer> EndFB_fwqlistContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_fwqlistContainer>(o);
  }
  public static void FinishFB_fwqlistContainerBuffer(FlatBufferBuilder builder, Offset<FB_fwqlistContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
