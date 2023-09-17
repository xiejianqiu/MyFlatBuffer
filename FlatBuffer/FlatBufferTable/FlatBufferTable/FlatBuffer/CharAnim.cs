// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_CharAnim : Table {
  public static FB_CharAnim GetRootAsFB_CharAnim(ByteBuffer _bb) { return GetRootAsFB_CharAnim(_bb, new FB_CharAnim()); }
  public static FB_CharAnim GetRootAsFB_CharAnim(ByteBuffer _bb, FB_CharAnim obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_CharAnim __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int Idle { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Run { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int CombatIdle { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int CombatRun { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Xiuxian { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int FlyIdle { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetFlyLandList(int j) { int o = __offset(18); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int FlyLandListLength { get { int o = __offset(18); return o != 0 ? __vector_len(o) : 0; } }
  public int GetFlyTakeOffList(int j) { int o = __offset(20); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int FlyTakeOffListLength { get { int o = __offset(20); return o != 0 ? __vector_len(o) : 0; } }
  public int FlyUp { get { int o = __offset(22); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int FlyDown { get { int o = __offset(24); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int PreFlySpeedUp { get { int o = __offset(26); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int FlySpeedUp { get { int o = __offset(28); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetFlyMoveList(int j) { int o = __offset(30); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int FlyMoveListLength { get { int o = __offset(30); return o != 0 ? __vector_len(o) : 0; } }
  public int GetFlyXiuXianList(int j) { int o = __offset(32); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int FlyXiuXianListLength { get { int o = __offset(32); return o != 0 ? __vector_len(o) : 0; } }
  public int CaiJi { get { int o = __offset(34); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_CharAnim> CreateFB_CharAnim(FlatBufferBuilder builder,
      int Id = 0,
      int Idle = -1,
      int Run = -1,
      int CombatIdle = -1,
      int CombatRun = -1,
      int Xiuxian = -1,
      int FlyIdle = -1,
      VectorOffset FlyLandList = default(VectorOffset),
      VectorOffset FlyTakeOffList = default(VectorOffset),
      int FlyUp = -1,
      int FlyDown = -1,
      int PreFlySpeedUp = -1,
      int FlySpeedUp = -1,
      VectorOffset FlyMoveList = default(VectorOffset),
      VectorOffset FlyXiuXianList = default(VectorOffset),
      int CaiJi = -1) {
    builder.StartObject(16);
    FB_CharAnim.AddCaiJi(builder, CaiJi);
    FB_CharAnim.AddFlyXiuXianList(builder, FlyXiuXianList);
    FB_CharAnim.AddFlyMoveList(builder, FlyMoveList);
    FB_CharAnim.AddFlySpeedUp(builder, FlySpeedUp);
    FB_CharAnim.AddPreFlySpeedUp(builder, PreFlySpeedUp);
    FB_CharAnim.AddFlyDown(builder, FlyDown);
    FB_CharAnim.AddFlyUp(builder, FlyUp);
    FB_CharAnim.AddFlyTakeOffList(builder, FlyTakeOffList);
    FB_CharAnim.AddFlyLandList(builder, FlyLandList);
    FB_CharAnim.AddFlyIdle(builder, FlyIdle);
    FB_CharAnim.AddXiuxian(builder, Xiuxian);
    FB_CharAnim.AddCombatRun(builder, CombatRun);
    FB_CharAnim.AddCombatIdle(builder, CombatIdle);
    FB_CharAnim.AddRun(builder, Run);
    FB_CharAnim.AddIdle(builder, Idle);
    FB_CharAnim.AddId(builder, Id);
    return FB_CharAnim.EndFB_CharAnim(builder);
  }

  public static void StartFB_CharAnim(FlatBufferBuilder builder) { builder.StartObject(16); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddIdle(FlatBufferBuilder builder, int Idle) { builder.AddInt(1, Idle, -1); }
  public static void AddRun(FlatBufferBuilder builder, int Run) { builder.AddInt(2, Run, -1); }
  public static void AddCombatIdle(FlatBufferBuilder builder, int CombatIdle) { builder.AddInt(3, CombatIdle, -1); }
  public static void AddCombatRun(FlatBufferBuilder builder, int CombatRun) { builder.AddInt(4, CombatRun, -1); }
  public static void AddXiuxian(FlatBufferBuilder builder, int Xiuxian) { builder.AddInt(5, Xiuxian, -1); }
  public static void AddFlyIdle(FlatBufferBuilder builder, int FlyIdle) { builder.AddInt(6, FlyIdle, -1); }
  public static void AddFlyLandList(FlatBufferBuilder builder, VectorOffset FlyLandListOffset) { builder.AddOffset(7, FlyLandListOffset.Value, 0); }
  public static VectorOffset CreateFlyLandListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartFlyLandListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddFlyTakeOffList(FlatBufferBuilder builder, VectorOffset FlyTakeOffListOffset) { builder.AddOffset(8, FlyTakeOffListOffset.Value, 0); }
  public static VectorOffset CreateFlyTakeOffListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartFlyTakeOffListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddFlyUp(FlatBufferBuilder builder, int FlyUp) { builder.AddInt(9, FlyUp, -1); }
  public static void AddFlyDown(FlatBufferBuilder builder, int FlyDown) { builder.AddInt(10, FlyDown, -1); }
  public static void AddPreFlySpeedUp(FlatBufferBuilder builder, int PreFlySpeedUp) { builder.AddInt(11, PreFlySpeedUp, -1); }
  public static void AddFlySpeedUp(FlatBufferBuilder builder, int FlySpeedUp) { builder.AddInt(12, FlySpeedUp, -1); }
  public static void AddFlyMoveList(FlatBufferBuilder builder, VectorOffset FlyMoveListOffset) { builder.AddOffset(13, FlyMoveListOffset.Value, 0); }
  public static VectorOffset CreateFlyMoveListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartFlyMoveListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddFlyXiuXianList(FlatBufferBuilder builder, VectorOffset FlyXiuXianListOffset) { builder.AddOffset(14, FlyXiuXianListOffset.Value, 0); }
  public static VectorOffset CreateFlyXiuXianListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartFlyXiuXianListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddCaiJi(FlatBufferBuilder builder, int CaiJi) { builder.AddInt(15, CaiJi, -1); }
  public static Offset<FB_CharAnim> EndFB_CharAnim(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_CharAnim>(o);
  }
};

public sealed class FB_CharAnimContainer : Table {
  public static FB_CharAnimContainer GetRootAsFB_CharAnimContainer(ByteBuffer _bb) { return GetRootAsFB_CharAnimContainer(_bb, new FB_CharAnimContainer()); }
  public static FB_CharAnimContainer GetRootAsFB_CharAnimContainer(ByteBuffer _bb, FB_CharAnimContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_CharAnimContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_CharAnimContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_CharAnim GetItems(int j) { return GetItems(new FB_CharAnim(), j); }
  public FB_CharAnim GetItems(FB_CharAnim obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_CharAnimContainer> CreateFB_CharAnimContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_CharAnimContainer.AddItems(builder, items);
    return FB_CharAnimContainer.EndFB_CharAnimContainer(builder);
  }

  public static void StartFB_CharAnimContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_CharAnim>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_CharAnimContainer> EndFB_CharAnimContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_CharAnimContainer>(o);
  }
  public static void FinishFB_CharAnimContainerBuffer(FlatBufferBuilder builder, Offset<FB_CharAnimContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
