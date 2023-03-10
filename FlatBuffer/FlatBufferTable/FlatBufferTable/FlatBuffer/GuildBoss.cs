// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_GuildBoss : Table {
  public static FB_GuildBoss GetRootAsFB_GuildBoss(ByteBuffer _bb) { return GetRootAsFB_GuildBoss(_bb, new FB_GuildBoss()); }
  public static FB_GuildBoss GetRootAsFB_GuildBoss(ByteBuffer _bb, FB_GuildBoss obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_GuildBoss __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int Level { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int OpenExpend { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int FirstExpend { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetRoleBaseIDList(int j) { int o = __offset(12); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int RoleBaseIDListLength { get { int o = __offset(12); return o != 0 ? __vector_len(o) : 0; } }
  public float PosX { get { int o = __offset(14); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)-1; } }
  public float PosZ { get { int o = __offset(16); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)-1; } }
  public float FaceDirection { get { int o = __offset(18); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)-1; } }
  public int GetShowItemIDList(int j) { int o = __offset(20); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int ShowItemIDListLength { get { int o = __offset(20); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_GuildBoss> CreateFB_GuildBoss(FlatBufferBuilder builder,
      int ID = 0,
      int Level = -1,
      int OpenExpend = -1,
      int FirstExpend = -1,
      VectorOffset RoleBaseIDList = default(VectorOffset),
      float PosX = -1,
      float PosZ = -1,
      float FaceDirection = -1,
      VectorOffset ShowItemIDList = default(VectorOffset)) {
    builder.StartObject(9);
    FB_GuildBoss.AddShowItemIDList(builder, ShowItemIDList);
    FB_GuildBoss.AddFaceDirection(builder, FaceDirection);
    FB_GuildBoss.AddPosZ(builder, PosZ);
    FB_GuildBoss.AddPosX(builder, PosX);
    FB_GuildBoss.AddRoleBaseIDList(builder, RoleBaseIDList);
    FB_GuildBoss.AddFirstExpend(builder, FirstExpend);
    FB_GuildBoss.AddOpenExpend(builder, OpenExpend);
    FB_GuildBoss.AddLevel(builder, Level);
    FB_GuildBoss.AddID(builder, ID);
    return FB_GuildBoss.EndFB_GuildBoss(builder);
  }

  public static void StartFB_GuildBoss(FlatBufferBuilder builder) { builder.StartObject(9); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddLevel(FlatBufferBuilder builder, int Level) { builder.AddInt(1, Level, -1); }
  public static void AddOpenExpend(FlatBufferBuilder builder, int OpenExpend) { builder.AddInt(2, OpenExpend, -1); }
  public static void AddFirstExpend(FlatBufferBuilder builder, int FirstExpend) { builder.AddInt(3, FirstExpend, -1); }
  public static void AddRoleBaseIDList(FlatBufferBuilder builder, VectorOffset RoleBaseIDListOffset) { builder.AddOffset(4, RoleBaseIDListOffset.Value, 0); }
  public static VectorOffset CreateRoleBaseIDListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartRoleBaseIDListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddPosX(FlatBufferBuilder builder, float PosX) { builder.AddFloat(5, PosX, -1); }
  public static void AddPosZ(FlatBufferBuilder builder, float PosZ) { builder.AddFloat(6, PosZ, -1); }
  public static void AddFaceDirection(FlatBufferBuilder builder, float FaceDirection) { builder.AddFloat(7, FaceDirection, -1); }
  public static void AddShowItemIDList(FlatBufferBuilder builder, VectorOffset ShowItemIDListOffset) { builder.AddOffset(8, ShowItemIDListOffset.Value, 0); }
  public static VectorOffset CreateShowItemIDListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartShowItemIDListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_GuildBoss> EndFB_GuildBoss(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_GuildBoss>(o);
  }
};

public sealed class FB_GuildBossContainer : Table {
  public static FB_GuildBossContainer GetRootAsFB_GuildBossContainer(ByteBuffer _bb) { return GetRootAsFB_GuildBossContainer(_bb, new FB_GuildBossContainer()); }
  public static FB_GuildBossContainer GetRootAsFB_GuildBossContainer(ByteBuffer _bb, FB_GuildBossContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_GuildBossContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_GuildBossContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_GuildBoss GetItems(int j) { return GetItems(new FB_GuildBoss(), j); }
  public FB_GuildBoss GetItems(FB_GuildBoss obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_GuildBossContainer> CreateFB_GuildBossContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_GuildBossContainer.AddItems(builder, items);
    return FB_GuildBossContainer.EndFB_GuildBossContainer(builder);
  }

  public static void StartFB_GuildBossContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_GuildBoss>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_GuildBossContainer> EndFB_GuildBossContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_GuildBossContainer>(o);
  }
  public static void FinishFB_GuildBossContainerBuffer(FlatBufferBuilder builder, Offset<FB_GuildBossContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
