// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_GetPathInfo : Table {
  public static FB_GetPathInfo GetRootAsFB_GetPathInfo(ByteBuffer _bb) { return GetRootAsFB_GetPathInfo(_bb, new FB_GetPathInfo()); }
  public static FB_GetPathInfo GetRootAsFB_GetPathInfo(ByteBuffer _bb, FB_GetPathInfo obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_GetPathInfo __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int GetGetPathInfoIDList(int j) { int o = __offset(6); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int GetPathInfoIDListLength { get { int o = __offset(6); return o != 0 ? __vector_len(o) : 0; } }
  public int NoPathID { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_GetPathInfo> CreateFB_GetPathInfo(FlatBufferBuilder builder,
      int Id = 0,
      VectorOffset GetPathInfoIDList = default(VectorOffset),
      int NoPathID = -1) {
    builder.StartObject(3);
    FB_GetPathInfo.AddNoPathID(builder, NoPathID);
    FB_GetPathInfo.AddGetPathInfoIDList(builder, GetPathInfoIDList);
    FB_GetPathInfo.AddId(builder, Id);
    return FB_GetPathInfo.EndFB_GetPathInfo(builder);
  }

  public static void StartFB_GetPathInfo(FlatBufferBuilder builder) { builder.StartObject(3); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddGetPathInfoIDList(FlatBufferBuilder builder, VectorOffset GetPathInfoIDListOffset) { builder.AddOffset(1, GetPathInfoIDListOffset.Value, 0); }
  public static VectorOffset CreateGetPathInfoIDListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartGetPathInfoIDListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddNoPathID(FlatBufferBuilder builder, int NoPathID) { builder.AddInt(2, NoPathID, -1); }
  public static Offset<FB_GetPathInfo> EndFB_GetPathInfo(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_GetPathInfo>(o);
  }
};

public sealed class FB_GetPathInfoContainer : Table {
  public static FB_GetPathInfoContainer GetRootAsFB_GetPathInfoContainer(ByteBuffer _bb) { return GetRootAsFB_GetPathInfoContainer(_bb, new FB_GetPathInfoContainer()); }
  public static FB_GetPathInfoContainer GetRootAsFB_GetPathInfoContainer(ByteBuffer _bb, FB_GetPathInfoContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_GetPathInfoContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_GetPathInfoContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_GetPathInfo GetItems(int j) { return GetItems(new FB_GetPathInfo(), j); }
  public FB_GetPathInfo GetItems(FB_GetPathInfo obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_GetPathInfoContainer> CreateFB_GetPathInfoContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_GetPathInfoContainer.AddItems(builder, items);
    return FB_GetPathInfoContainer.EndFB_GetPathInfoContainer(builder);
  }

  public static void StartFB_GetPathInfoContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_GetPathInfo>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_GetPathInfoContainer> EndFB_GetPathInfoContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_GetPathInfoContainer>(o);
  }
  public static void FinishFB_GetPathInfoContainerBuffer(FlatBufferBuilder builder, Offset<FB_GetPathInfoContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
