// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_TeamShip : Table {
  public static FB_TeamShip GetRootAsFB_TeamShip(ByteBuffer _bb) { return GetRootAsFB_TeamShip(_bb, new FB_TeamShip()); }
  public static FB_TeamShip GetRootAsFB_TeamShip(ByteBuffer _bb, FB_TeamShip obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_TeamShip __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Name { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public string Icon { get { int o = __offset(8); return o != 0 ? __string(o + bb_pos) : null; } }
  public int Tips { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int FakeObjectID { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int CharMountID { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetPathID { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetPathItemId { get { int o = __offset(18); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int UnlockType { get { int o = __offset(20); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int UnlockParam { get { int o = __offset(22); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int StartEffectId { get { int o = __offset(24); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int EndEffectId { get { int o = __offset(26); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int EnterEffectId { get { int o = __offset(28); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_TeamShip> CreateFB_TeamShip(FlatBufferBuilder builder,
      int ID = 0,
      StringOffset Name = default(StringOffset),
      StringOffset Icon = default(StringOffset),
      int Tips = -1,
      int FakeObjectID = -1,
      int CharMountID = -1,
      int GetPathID = -1,
      int GetPathItemId = -1,
      int UnlockType = -1,
      int UnlockParam = -1,
      int StartEffectId = -1,
      int EndEffectId = -1,
      int EnterEffectId = -1) {
    builder.StartObject(13);
    FB_TeamShip.AddEnterEffectId(builder, EnterEffectId);
    FB_TeamShip.AddEndEffectId(builder, EndEffectId);
    FB_TeamShip.AddStartEffectId(builder, StartEffectId);
    FB_TeamShip.AddUnlockParam(builder, UnlockParam);
    FB_TeamShip.AddUnlockType(builder, UnlockType);
    FB_TeamShip.AddGetPathItemId(builder, GetPathItemId);
    FB_TeamShip.AddGetPathID(builder, GetPathID);
    FB_TeamShip.AddCharMountID(builder, CharMountID);
    FB_TeamShip.AddFakeObjectID(builder, FakeObjectID);
    FB_TeamShip.AddTips(builder, Tips);
    FB_TeamShip.AddIcon(builder, Icon);
    FB_TeamShip.AddName(builder, Name);
    FB_TeamShip.AddID(builder, ID);
    return FB_TeamShip.EndFB_TeamShip(builder);
  }

  public static void StartFB_TeamShip(FlatBufferBuilder builder) { builder.StartObject(13); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(1, NameOffset.Value, 0); }
  public static void AddIcon(FlatBufferBuilder builder, StringOffset IconOffset) { builder.AddOffset(2, IconOffset.Value, 0); }
  public static void AddTips(FlatBufferBuilder builder, int Tips) { builder.AddInt(3, Tips, -1); }
  public static void AddFakeObjectID(FlatBufferBuilder builder, int FakeObjectID) { builder.AddInt(4, FakeObjectID, -1); }
  public static void AddCharMountID(FlatBufferBuilder builder, int CharMountID) { builder.AddInt(5, CharMountID, -1); }
  public static void AddGetPathID(FlatBufferBuilder builder, int GetPathID) { builder.AddInt(6, GetPathID, -1); }
  public static void AddGetPathItemId(FlatBufferBuilder builder, int GetPathItemId) { builder.AddInt(7, GetPathItemId, -1); }
  public static void AddUnlockType(FlatBufferBuilder builder, int UnlockType) { builder.AddInt(8, UnlockType, -1); }
  public static void AddUnlockParam(FlatBufferBuilder builder, int UnlockParam) { builder.AddInt(9, UnlockParam, -1); }
  public static void AddStartEffectId(FlatBufferBuilder builder, int StartEffectId) { builder.AddInt(10, StartEffectId, -1); }
  public static void AddEndEffectId(FlatBufferBuilder builder, int EndEffectId) { builder.AddInt(11, EndEffectId, -1); }
  public static void AddEnterEffectId(FlatBufferBuilder builder, int EnterEffectId) { builder.AddInt(12, EnterEffectId, -1); }
  public static Offset<FB_TeamShip> EndFB_TeamShip(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_TeamShip>(o);
  }
};

public sealed class FB_TeamShipContainer : Table {
  public static FB_TeamShipContainer GetRootAsFB_TeamShipContainer(ByteBuffer _bb) { return GetRootAsFB_TeamShipContainer(_bb, new FB_TeamShipContainer()); }
  public static FB_TeamShipContainer GetRootAsFB_TeamShipContainer(ByteBuffer _bb, FB_TeamShipContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_TeamShipContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_TeamShipContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_TeamShip GetItems(int j) { return GetItems(new FB_TeamShip(), j); }
  public FB_TeamShip GetItems(FB_TeamShip obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_TeamShipContainer> CreateFB_TeamShipContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_TeamShipContainer.AddItems(builder, items);
    return FB_TeamShipContainer.EndFB_TeamShipContainer(builder);
  }

  public static void StartFB_TeamShipContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_TeamShip>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_TeamShipContainer> EndFB_TeamShipContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_TeamShipContainer>(o);
  }
  public static void FinishFB_TeamShipContainerBuffer(FlatBufferBuilder builder, Offset<FB_TeamShipContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
