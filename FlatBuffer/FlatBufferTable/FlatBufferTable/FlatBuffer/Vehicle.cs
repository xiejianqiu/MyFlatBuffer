// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_Vehicle : Table {
  public static FB_Vehicle GetRootAsFB_Vehicle(ByteBuffer _bb) { return GetRootAsFB_Vehicle(_bb, new FB_Vehicle()); }
  public static FB_Vehicle GetRootAsFB_Vehicle(ByteBuffer _bb, FB_Vehicle obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_Vehicle __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int RoleBaseId { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public bool ModifyAttr { get { int o = __offset(8); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)false; } }
  public bool CanBattle { get { int o = __offset(10); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)false; } }
  public int ExistTime { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)3; } }
  public bool CanFly { get { int o = __offset(14); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)false; } }
  public bool CanQuit { get { int o = __offset(16); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)false; } }
  public int ScriptId { get { int o = __offset(18); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int CamXAngle { get { int o = __offset(20); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int CamYAngel { get { int o = __offset(22); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public float CamDis { get { int o = __offset(24); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }

  public static Offset<FB_Vehicle> CreateFB_Vehicle(FlatBufferBuilder builder,
      int Id = 0,
      int RoleBaseId = -1,
      bool ModifyAttr = false,
      bool CanBattle = false,
      int ExistTime = 3,
      bool CanFly = false,
      bool CanQuit = false,
      int ScriptId = -1,
      int CamXAngle = 0,
      int CamYAngel = 0,
      float CamDis = 0) {
    builder.StartObject(11);
    FB_Vehicle.AddCamDis(builder, CamDis);
    FB_Vehicle.AddCamYAngel(builder, CamYAngel);
    FB_Vehicle.AddCamXAngle(builder, CamXAngle);
    FB_Vehicle.AddScriptId(builder, ScriptId);
    FB_Vehicle.AddExistTime(builder, ExistTime);
    FB_Vehicle.AddRoleBaseId(builder, RoleBaseId);
    FB_Vehicle.AddId(builder, Id);
    FB_Vehicle.AddCanQuit(builder, CanQuit);
    FB_Vehicle.AddCanFly(builder, CanFly);
    FB_Vehicle.AddCanBattle(builder, CanBattle);
    FB_Vehicle.AddModifyAttr(builder, ModifyAttr);
    return FB_Vehicle.EndFB_Vehicle(builder);
  }

  public static void StartFB_Vehicle(FlatBufferBuilder builder) { builder.StartObject(11); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddRoleBaseId(FlatBufferBuilder builder, int RoleBaseId) { builder.AddInt(1, RoleBaseId, -1); }
  public static void AddModifyAttr(FlatBufferBuilder builder, bool ModifyAttr) { builder.AddBool(2, ModifyAttr, false); }
  public static void AddCanBattle(FlatBufferBuilder builder, bool CanBattle) { builder.AddBool(3, CanBattle, false); }
  public static void AddExistTime(FlatBufferBuilder builder, int ExistTime) { builder.AddInt(4, ExistTime, 3); }
  public static void AddCanFly(FlatBufferBuilder builder, bool CanFly) { builder.AddBool(5, CanFly, false); }
  public static void AddCanQuit(FlatBufferBuilder builder, bool CanQuit) { builder.AddBool(6, CanQuit, false); }
  public static void AddScriptId(FlatBufferBuilder builder, int ScriptId) { builder.AddInt(7, ScriptId, -1); }
  public static void AddCamXAngle(FlatBufferBuilder builder, int CamXAngle) { builder.AddInt(8, CamXAngle, 0); }
  public static void AddCamYAngel(FlatBufferBuilder builder, int CamYAngel) { builder.AddInt(9, CamYAngel, 0); }
  public static void AddCamDis(FlatBufferBuilder builder, float CamDis) { builder.AddFloat(10, CamDis, 0); }
  public static Offset<FB_Vehicle> EndFB_Vehicle(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_Vehicle>(o);
  }
};

public sealed class FB_VehicleContainer : Table {
  public static FB_VehicleContainer GetRootAsFB_VehicleContainer(ByteBuffer _bb) { return GetRootAsFB_VehicleContainer(_bb, new FB_VehicleContainer()); }
  public static FB_VehicleContainer GetRootAsFB_VehicleContainer(ByteBuffer _bb, FB_VehicleContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_VehicleContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_VehicleContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_Vehicle GetItems(int j) { return GetItems(new FB_Vehicle(), j); }
  public FB_Vehicle GetItems(FB_Vehicle obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_VehicleContainer> CreateFB_VehicleContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_VehicleContainer.AddItems(builder, items);
    return FB_VehicleContainer.EndFB_VehicleContainer(builder);
  }

  public static void StartFB_VehicleContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_Vehicle>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_VehicleContainer> EndFB_VehicleContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_VehicleContainer>(o);
  }
  public static void FinishFB_VehicleContainerBuffer(FlatBufferBuilder builder, Offset<FB_VehicleContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
