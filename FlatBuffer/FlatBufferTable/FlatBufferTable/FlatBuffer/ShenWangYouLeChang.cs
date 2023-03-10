// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_ShenWangYouLeChang : Table {
  public static FB_ShenWangYouLeChang GetRootAsFB_ShenWangYouLeChang(ByteBuffer _bb) { return GetRootAsFB_ShenWangYouLeChang(_bb, new FB_ShenWangYouLeChang()); }
  public static FB_ShenWangYouLeChang GetRootAsFB_ShenWangYouLeChang(ByteBuffer _bb, FB_ShenWangYouLeChang obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_ShenWangYouLeChang __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string MonsterName { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public int PosX { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int PosZ { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetRoleBaseIDList(int j) { int o = __offset(12); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int RoleBaseIDListLength { get { int o = __offset(12); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_ShenWangYouLeChang> CreateFB_ShenWangYouLeChang(FlatBufferBuilder builder,
      int Id = 0,
      StringOffset MonsterName = default(StringOffset),
      int PosX = -1,
      int PosZ = -1,
      VectorOffset RoleBaseIDList = default(VectorOffset)) {
    builder.StartObject(5);
    FB_ShenWangYouLeChang.AddRoleBaseIDList(builder, RoleBaseIDList);
    FB_ShenWangYouLeChang.AddPosZ(builder, PosZ);
    FB_ShenWangYouLeChang.AddPosX(builder, PosX);
    FB_ShenWangYouLeChang.AddMonsterName(builder, MonsterName);
    FB_ShenWangYouLeChang.AddId(builder, Id);
    return FB_ShenWangYouLeChang.EndFB_ShenWangYouLeChang(builder);
  }

  public static void StartFB_ShenWangYouLeChang(FlatBufferBuilder builder) { builder.StartObject(5); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddMonsterName(FlatBufferBuilder builder, StringOffset MonsterNameOffset) { builder.AddOffset(1, MonsterNameOffset.Value, 0); }
  public static void AddPosX(FlatBufferBuilder builder, int PosX) { builder.AddInt(2, PosX, -1); }
  public static void AddPosZ(FlatBufferBuilder builder, int PosZ) { builder.AddInt(3, PosZ, -1); }
  public static void AddRoleBaseIDList(FlatBufferBuilder builder, VectorOffset RoleBaseIDListOffset) { builder.AddOffset(4, RoleBaseIDListOffset.Value, 0); }
  public static VectorOffset CreateRoleBaseIDListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartRoleBaseIDListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_ShenWangYouLeChang> EndFB_ShenWangYouLeChang(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ShenWangYouLeChang>(o);
  }
};

public sealed class FB_ShenWangYouLeChangContainer : Table {
  public static FB_ShenWangYouLeChangContainer GetRootAsFB_ShenWangYouLeChangContainer(ByteBuffer _bb) { return GetRootAsFB_ShenWangYouLeChangContainer(_bb, new FB_ShenWangYouLeChangContainer()); }
  public static FB_ShenWangYouLeChangContainer GetRootAsFB_ShenWangYouLeChangContainer(ByteBuffer _bb, FB_ShenWangYouLeChangContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_ShenWangYouLeChangContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_ShenWangYouLeChangContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_ShenWangYouLeChang GetItems(int j) { return GetItems(new FB_ShenWangYouLeChang(), j); }
  public FB_ShenWangYouLeChang GetItems(FB_ShenWangYouLeChang obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_ShenWangYouLeChangContainer> CreateFB_ShenWangYouLeChangContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_ShenWangYouLeChangContainer.AddItems(builder, items);
    return FB_ShenWangYouLeChangContainer.EndFB_ShenWangYouLeChangContainer(builder);
  }

  public static void StartFB_ShenWangYouLeChangContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_ShenWangYouLeChang>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_ShenWangYouLeChangContainer> EndFB_ShenWangYouLeChangContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ShenWangYouLeChangContainer>(o);
  }
  public static void FinishFB_ShenWangYouLeChangContainerBuffer(FlatBufferBuilder builder, Offset<FB_ShenWangYouLeChangContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
