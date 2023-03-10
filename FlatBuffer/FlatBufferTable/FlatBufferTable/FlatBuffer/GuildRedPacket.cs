// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_GuildRedPacket : Table {
  public static FB_GuildRedPacket GetRootAsFB_GuildRedPacket(ByteBuffer _bb) { return GetRootAsFB_GuildRedPacket(_bb, new FB_GuildRedPacket()); }
  public static FB_GuildRedPacket GetRootAsFB_GuildRedPacket(ByteBuffer _bb, FB_GuildRedPacket obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_GuildRedPacket __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string FirstName { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public string AccumulatedName { get { int o = __offset(8); return o != 0 ? __string(o + bb_pos) : null; } }
  public int FirstNotice { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int AccumulatedNotice { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetAccomplishList(int j) { int o = __offset(14); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AccomplishListLength { get { int o = __offset(14); return o != 0 ? __vector_len(o) : 0; } }
  public int GetAwardList(int j) { int o = __offset(16); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AwardListLength { get { int o = __offset(16); return o != 0 ? __vector_len(o) : 0; } }
  public int CountLimit { get { int o = __offset(18); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_GuildRedPacket> CreateFB_GuildRedPacket(FlatBufferBuilder builder,
      int ID = 0,
      StringOffset FirstName = default(StringOffset),
      StringOffset AccumulatedName = default(StringOffset),
      int FirstNotice = -1,
      int AccumulatedNotice = -1,
      VectorOffset AccomplishList = default(VectorOffset),
      VectorOffset AwardList = default(VectorOffset),
      int CountLimit = -1) {
    builder.StartObject(8);
    FB_GuildRedPacket.AddCountLimit(builder, CountLimit);
    FB_GuildRedPacket.AddAwardList(builder, AwardList);
    FB_GuildRedPacket.AddAccomplishList(builder, AccomplishList);
    FB_GuildRedPacket.AddAccumulatedNotice(builder, AccumulatedNotice);
    FB_GuildRedPacket.AddFirstNotice(builder, FirstNotice);
    FB_GuildRedPacket.AddAccumulatedName(builder, AccumulatedName);
    FB_GuildRedPacket.AddFirstName(builder, FirstName);
    FB_GuildRedPacket.AddID(builder, ID);
    return FB_GuildRedPacket.EndFB_GuildRedPacket(builder);
  }

  public static void StartFB_GuildRedPacket(FlatBufferBuilder builder) { builder.StartObject(8); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddFirstName(FlatBufferBuilder builder, StringOffset FirstNameOffset) { builder.AddOffset(1, FirstNameOffset.Value, 0); }
  public static void AddAccumulatedName(FlatBufferBuilder builder, StringOffset AccumulatedNameOffset) { builder.AddOffset(2, AccumulatedNameOffset.Value, 0); }
  public static void AddFirstNotice(FlatBufferBuilder builder, int FirstNotice) { builder.AddInt(3, FirstNotice, -1); }
  public static void AddAccumulatedNotice(FlatBufferBuilder builder, int AccumulatedNotice) { builder.AddInt(4, AccumulatedNotice, -1); }
  public static void AddAccomplishList(FlatBufferBuilder builder, VectorOffset AccomplishListOffset) { builder.AddOffset(5, AccomplishListOffset.Value, 0); }
  public static VectorOffset CreateAccomplishListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAccomplishListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddAwardList(FlatBufferBuilder builder, VectorOffset AwardListOffset) { builder.AddOffset(6, AwardListOffset.Value, 0); }
  public static VectorOffset CreateAwardListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAwardListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddCountLimit(FlatBufferBuilder builder, int CountLimit) { builder.AddInt(7, CountLimit, -1); }
  public static Offset<FB_GuildRedPacket> EndFB_GuildRedPacket(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_GuildRedPacket>(o);
  }
};

public sealed class FB_GuildRedPacketContainer : Table {
  public static FB_GuildRedPacketContainer GetRootAsFB_GuildRedPacketContainer(ByteBuffer _bb) { return GetRootAsFB_GuildRedPacketContainer(_bb, new FB_GuildRedPacketContainer()); }
  public static FB_GuildRedPacketContainer GetRootAsFB_GuildRedPacketContainer(ByteBuffer _bb, FB_GuildRedPacketContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_GuildRedPacketContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_GuildRedPacketContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_GuildRedPacket GetItems(int j) { return GetItems(new FB_GuildRedPacket(), j); }
  public FB_GuildRedPacket GetItems(FB_GuildRedPacket obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_GuildRedPacketContainer> CreateFB_GuildRedPacketContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_GuildRedPacketContainer.AddItems(builder, items);
    return FB_GuildRedPacketContainer.EndFB_GuildRedPacketContainer(builder);
  }

  public static void StartFB_GuildRedPacketContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_GuildRedPacket>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_GuildRedPacketContainer> EndFB_GuildRedPacketContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_GuildRedPacketContainer>(o);
  }
  public static void FinishFB_GuildRedPacketContainerBuffer(FlatBufferBuilder builder, Offset<FB_GuildRedPacketContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
