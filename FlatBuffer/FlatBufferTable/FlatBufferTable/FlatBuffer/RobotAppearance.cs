// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_RobotAppearance : Table {
  public static FB_RobotAppearance GetRootAsFB_RobotAppearance(ByteBuffer _bb) { return GetRootAsFB_RobotAppearance(_bb, new FB_RobotAppearance()); }
  public static FB_RobotAppearance GetRootAsFB_RobotAppearance(ByteBuffer _bb, FB_RobotAppearance obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_RobotAppearance __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int MenPai { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Sex { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int CharModelID { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_RobotAppearance> CreateFB_RobotAppearance(FlatBufferBuilder builder,
      int ID = 0,
      int MenPai = -1,
      int sex = -1,
      int charModelID = -1) {
    builder.StartObject(4);
    FB_RobotAppearance.AddCharModelID(builder, charModelID);
    FB_RobotAppearance.AddSex(builder, sex);
    FB_RobotAppearance.AddMenPai(builder, MenPai);
    FB_RobotAppearance.AddID(builder, ID);
    return FB_RobotAppearance.EndFB_RobotAppearance(builder);
  }

  public static void StartFB_RobotAppearance(FlatBufferBuilder builder) { builder.StartObject(4); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddMenPai(FlatBufferBuilder builder, int MenPai) { builder.AddInt(1, MenPai, -1); }
  public static void AddSex(FlatBufferBuilder builder, int sex) { builder.AddInt(2, sex, -1); }
  public static void AddCharModelID(FlatBufferBuilder builder, int charModelID) { builder.AddInt(3, charModelID, -1); }
  public static Offset<FB_RobotAppearance> EndFB_RobotAppearance(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_RobotAppearance>(o);
  }
};

public sealed class FB_RobotAppearanceContainer : Table {
  public static FB_RobotAppearanceContainer GetRootAsFB_RobotAppearanceContainer(ByteBuffer _bb) { return GetRootAsFB_RobotAppearanceContainer(_bb, new FB_RobotAppearanceContainer()); }
  public static FB_RobotAppearanceContainer GetRootAsFB_RobotAppearanceContainer(ByteBuffer _bb, FB_RobotAppearanceContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_RobotAppearanceContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_RobotAppearanceContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_RobotAppearance GetItems(int j) { return GetItems(new FB_RobotAppearance(), j); }
  public FB_RobotAppearance GetItems(FB_RobotAppearance obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_RobotAppearanceContainer> CreateFB_RobotAppearanceContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_RobotAppearanceContainer.AddItems(builder, items);
    return FB_RobotAppearanceContainer.EndFB_RobotAppearanceContainer(builder);
  }

  public static void StartFB_RobotAppearanceContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_RobotAppearance>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_RobotAppearanceContainer> EndFB_RobotAppearanceContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_RobotAppearanceContainer>(o);
  }
  public static void FinishFB_RobotAppearanceContainerBuffer(FlatBufferBuilder builder, Offset<FB_RobotAppearanceContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
