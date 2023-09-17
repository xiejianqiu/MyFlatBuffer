// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_StarCraftTicket : Table {
  public static FB_StarCraftTicket GetRootAsFB_StarCraftTicket(ByteBuffer _bb) { return GetRootAsFB_StarCraftTicket(_bb, new FB_StarCraftTicket()); }
  public static FB_StarCraftTicket GetRootAsFB_StarCraftTicket(ByteBuffer _bb, FB_StarCraftTicket obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_StarCraftTicket __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int Type { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetParamList(int j) { int o = __offset(8); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int ParamListLength { get { int o = __offset(8); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_StarCraftTicket> CreateFB_StarCraftTicket(FlatBufferBuilder builder,
      int ID = 0,
      int Type = -1,
      VectorOffset ParamList = default(VectorOffset)) {
    builder.StartObject(3);
    FB_StarCraftTicket.AddParamList(builder, ParamList);
    FB_StarCraftTicket.AddType(builder, Type);
    FB_StarCraftTicket.AddID(builder, ID);
    return FB_StarCraftTicket.EndFB_StarCraftTicket(builder);
  }

  public static void StartFB_StarCraftTicket(FlatBufferBuilder builder) { builder.StartObject(3); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddType(FlatBufferBuilder builder, int Type) { builder.AddInt(1, Type, -1); }
  public static void AddParamList(FlatBufferBuilder builder, VectorOffset ParamListOffset) { builder.AddOffset(2, ParamListOffset.Value, 0); }
  public static VectorOffset CreateParamListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartParamListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_StarCraftTicket> EndFB_StarCraftTicket(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_StarCraftTicket>(o);
  }
};

public sealed class FB_StarCraftTicketContainer : Table {
  public static FB_StarCraftTicketContainer GetRootAsFB_StarCraftTicketContainer(ByteBuffer _bb) { return GetRootAsFB_StarCraftTicketContainer(_bb, new FB_StarCraftTicketContainer()); }
  public static FB_StarCraftTicketContainer GetRootAsFB_StarCraftTicketContainer(ByteBuffer _bb, FB_StarCraftTicketContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_StarCraftTicketContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_StarCraftTicketContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_StarCraftTicket GetItems(int j) { return GetItems(new FB_StarCraftTicket(), j); }
  public FB_StarCraftTicket GetItems(FB_StarCraftTicket obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_StarCraftTicketContainer> CreateFB_StarCraftTicketContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_StarCraftTicketContainer.AddItems(builder, items);
    return FB_StarCraftTicketContainer.EndFB_StarCraftTicketContainer(builder);
  }

  public static void StartFB_StarCraftTicketContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_StarCraftTicket>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_StarCraftTicketContainer> EndFB_StarCraftTicketContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_StarCraftTicketContainer>(o);
  }
  public static void FinishFB_StarCraftTicketContainerBuffer(FlatBufferBuilder builder, Offset<FB_StarCraftTicketContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
