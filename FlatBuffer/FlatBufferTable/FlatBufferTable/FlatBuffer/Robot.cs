// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_Robot : Table {
  public static FB_Robot GetRootAsFB_Robot(ByteBuffer _bb) { return GetRootAsFB_Robot(_bb, new FB_Robot()); }
  public static FB_Robot GetRootAsFB_Robot(ByteBuffer _bb, FB_Robot obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_Robot __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int FaceId { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int HairModelId { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int DefultCharModel { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_Robot> CreateFB_Robot(FlatBufferBuilder builder,
      int Id = 0,
      int FaceId = -1,
      int HairModelId = -1,
      int DefultCharModel = -1) {
    builder.StartObject(4);
    FB_Robot.AddDefultCharModel(builder, DefultCharModel);
    FB_Robot.AddHairModelId(builder, HairModelId);
    FB_Robot.AddFaceId(builder, FaceId);
    FB_Robot.AddId(builder, Id);
    return FB_Robot.EndFB_Robot(builder);
  }

  public static void StartFB_Robot(FlatBufferBuilder builder) { builder.StartObject(4); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddFaceId(FlatBufferBuilder builder, int FaceId) { builder.AddInt(1, FaceId, -1); }
  public static void AddHairModelId(FlatBufferBuilder builder, int HairModelId) { builder.AddInt(2, HairModelId, -1); }
  public static void AddDefultCharModel(FlatBufferBuilder builder, int DefultCharModel) { builder.AddInt(3, DefultCharModel, -1); }
  public static Offset<FB_Robot> EndFB_Robot(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_Robot>(o);
  }
};

public sealed class FB_RobotContainer : Table {
  public static FB_RobotContainer GetRootAsFB_RobotContainer(ByteBuffer _bb) { return GetRootAsFB_RobotContainer(_bb, new FB_RobotContainer()); }
  public static FB_RobotContainer GetRootAsFB_RobotContainer(ByteBuffer _bb, FB_RobotContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_RobotContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_RobotContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_Robot GetItems(int j) { return GetItems(new FB_Robot(), j); }
  public FB_Robot GetItems(FB_Robot obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_RobotContainer> CreateFB_RobotContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_RobotContainer.AddItems(builder, items);
    return FB_RobotContainer.EndFB_RobotContainer(builder);
  }

  public static void StartFB_RobotContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_Robot>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_RobotContainer> EndFB_RobotContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_RobotContainer>(o);
  }
  public static void FinishFB_RobotContainerBuffer(FlatBufferBuilder builder, Offset<FB_RobotContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
